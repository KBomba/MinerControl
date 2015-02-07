using System;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

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
                ErrorLogger.Log(ex);
            }
        }

        private static void DownloadJsonComplete(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                string pageString = e.Result;
                if (pageString == null) return;
                Action<object> jsonProcessor = e.UserState as Action<object>;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                object data = serializer.DeserializeObject(pageString);

                jsonProcessor(data);
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(ex);
            }
        }
    }
}