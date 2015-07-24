using System;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using MinerControl.Services;

namespace MinerControl.Utility
{
    public static class WebUtil
    {
        public static void DownloadJson(string url, Action<object> jsonProcessor)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    Uri uri = new Uri(url);
                    client.Encoding = Encoding.UTF8;
                    client.DownloadStringCompleted += DownloadJsonComplete;
                    client.DownloadStringAsync(uri, jsonProcessor);
                }
            }
            catch (Exception ex)
            {
                IService service = jsonProcessor.Target as IService;
                if (service != null && jsonProcessor.Method.Name == "ProcessPrices") service.UpdateHistory(true);
                // Makes sure the service is updated if price retrieval errors out
                ErrorLogger.Log(ex);
            }
        }

        private static void DownloadJsonComplete(object sender, DownloadStringCompletedEventArgs e)
        {
            Action<object> jsonProcessor = e.UserState as Action<object>;
            if (jsonProcessor != null)
            {
                try
                {
                    string pageString = e.Result;
                    if (pageString == null) return;
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    object data = serializer.DeserializeObject(pageString);

                    jsonProcessor(data);
                }
                catch (Exception ex)
                {
                    IService service = jsonProcessor.Target as IService;
                    if (service != null && jsonProcessor.Method.Name == "ProcessPrices") service.UpdateHistory(true);
                    ErrorLogger.Log(ex);
                }
            }
        }
    }
}