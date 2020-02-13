using System;
using System.Collections.Specialized;
using System.Web;

namespace JobAds.Extensions
{
    // Uri extensions for simplier url manipulation.
    public static class UriExtensions
    {
        // Set Url parameter for the url.
        public static Uri SetQueryValue(this Uri uri, string name, object value)
        {
            NameValueCollection nvc = HttpUtility.ParseQueryString(uri.Query);
            nvc[name] = (value ?? string.Empty).ToString();

            return new UriBuilder(uri) { Query = nvc.ToString() }.Uri;
        }

        // Increase numerical query parameter by one.
        public static Uri IncreaseQueryIntegerValue(this Uri uri, string name)
        {
            var websiteParam = HttpUtility.ParseQueryString(uri.Query)
                .Get(name);

            int.TryParse(websiteParam, out int paramValue);

            paramValue++;

            return uri.SetQueryValue(name, paramValue);
        }



    }
}