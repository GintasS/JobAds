using JobAds.Extensions;
using System;
using System.Text.RegularExpressions;
using System.Web;

namespace JobAds.Models
{
    // Website instance that holds data about current user selected website.
    public class Website
    {
        public Uri Url { get; set; }

        public int? MaxWebsiteJobs { get; set; }

        public Website(string url)
        {
            SetWebsiteUrl(url);
            SetWebsitePageNumber();
        }

        // Get website url & page number.
        private void SetWebsiteUrl(string url)
        {
            // If url does not contain a page number parameter, add it.
            if (Regex.IsMatch(url, Constants.Regex.CVonlineUrl) && 
                url.IndexOf(Constants.WebsiteParam.QuestionPage) == -1)
            {
                url += Constants.WebsiteParam.QuestionPage;       
            }
            else if (Regex.IsMatch(url, Constants.Regex.CVbankasUrl) && 
                url.IndexOf(Constants.WebsiteParam.AndPage) == -1)
            {
                url += Constants.WebsiteParam.AndPage + Constants.Character.One;
            }

            Url = new Uri(url);
        }

        private void SetWebsitePageNumber()
        {
            var websiteParam = HttpUtility.ParseQueryString(Url.Query)
                .Get(Constants.WebsiteParam.Page);

            Url = Url.SetQueryValue(Constants.WebsiteParam.Page, websiteParam);
        }

        // Check if user entered a valid url that we can scrap.
        public static bool IsValidUrl(string url)
        {
            return Regex.IsMatch(url, Constants.Regex.CVonlineUrl) ||
                Regex.IsMatch(url, Constants.Regex.CVbankasUrl);
        }



    }
}