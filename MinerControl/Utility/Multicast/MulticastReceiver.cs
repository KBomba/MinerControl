using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MinerControl.Utility.Multicast
{
    public delegate void MulticastDataReceivedEventHandler(object sender, MulticastDataReceivedEventArgs e);

    public class MulticastReceiver : IDisposable
    {
        private readonly IPEndPoint _endPoint;
        private bool _disposed;
        private Thread _listener;

        public MulticastReceiver(IPEndPoint endPoint)
        {
            _endPoint = endPoint;
        }

        public void Dispose()
        {
            if (_disposed) return;
            if (_listener.IsAlive)
            {
                Stop();
            }
            _disposed = true;
        }

        public event MulticastDataReceivedEventHandler DataReceived;

        public void Start()
        {
            _listener = new Thread(BackgroundListener)
            {
                IsBackground = true
            };
            _listener.Start();
        }

        public void Stop()
        {
            lock (this)
            {
                _listener.Abort();
                _listener.Join(500);
            }
        }

        private void BackgroundListener()
        {
            IPEndPoint bindingEndpoint = new IPEndPoint(IPAddress.Any, _endPoint.Port);
            using (UdpClient client = new UdpClient())
            {
                client.ExclusiveAddressUse = false;
                client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                client.Client.Bind(bindingEndpoint);
                client.JoinMulticastGroup(_endPoint.Address);

                bool keepRunning = true;
                while (keepRunning)
                {
                    try
                    {
                        IPEndPoint remote = new IPEndPoint(IPAddress.Any, _endPoint.Port);
                        byte[] buffer = client.Receive(ref remote);
                        lock (this)
                        {
                            DataReceived(this, new MulticastDataReceivedEventArgs(remote, buffer));
                        }
                    }
                    catch (ThreadAbortException)
                    {
                        keepRunning = false;
                        Thread.ResetAbort();
                    }
                }

                client.DropMulticastGroup(_endPoint.Address);
            }
        }
    }
}