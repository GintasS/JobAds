using HtmlAgilityPack;
using System.Net;

namespace JobAds
{
    // Custom web client for various HTTP actions.
    public class CustomWebClient
    {
        // Get html document from url.
        public static HtmlDocument GetHtmlDocument(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var web = new HtmlWeb();
            var htmlDoc = new HtmlDocument();

            // Try to load html from internet resource.
            try
            {
                htmlDoc = web.Load(url);
            }
            catch
            {
                htmlDoc = null;
            }

            return htmlDoc;
        }

        // Download a resource as a string.
        public static string DownloadString(string url)
        {
            string response = null;

            try
            {
                response = new WebClient().DownloadString(url);
            }
            catch
            {
                response = null;
            }

            return response;
        }



    }
}
