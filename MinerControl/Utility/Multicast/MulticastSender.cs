using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MinerControl.Utility.Multicast
{
    public class MulticastSender : IDisposable
    {
        private readonly IPEndPoint _endPoint;
        private readonly int _timeToLive;
        private bool _disposed;
        private UdpClient _udpClient;

        public MulticastSender(IPEndPoint endPoint, int timeToLive)
        {
            _endPoint = endPoint;
            _timeToLive = timeToLive;
        }

        public void Dispose()
        {
            if (_disposed) return;
            if (_udpClient != null)
            {
                Stop();
            }
            _disposed = true;
        }

        public void Start()
        {
            IPEndPoint bindingEndpoint = new IPEndPoint(IPAddress.Any, _endPoint.Port);

            _udpClient = new UdpClient {ExclusiveAddressUse = false};
            _udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _udpClient.Client.Bind(bindingEndpoint);
            _udpClient.JoinMulticastGroup(_endPoint.Address, _timeToLive);
        }

        public void Stop()
        {
            _udpClient.DropMulticastGroup(_endPoint.Address);
            _udpClient.Close();
            _udpClient = null;
        }

        public void Send(byte[] data)
        {
            _udpClient.Send(data, data.Length, _endPoint);
        }

        public void Send(string data)
        {
            Send(Encoding.Unicode.GetBytes(data));
        }
    }
}