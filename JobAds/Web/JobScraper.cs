using HtmlAgilityPack;
using JobAds.Models;
using System.Collections.Generic;
using JobAds.Extensions;
using System.Drawing;
using System.Threading;
using System.Linq;

namespace JobAds
{
    public class JobScraper
    {
        private static Website Website;
        public static List<Job> Jobs { get; private set; } = new List<Job>();

        // Get all jobs from a single url.
        public static List<Job> GetJobs(HtmlDocument htmlBody, string[] xpaths, bool descriptionScraping)
        {
            var jobs = new List<Job>();

            var htmlNodes = htmlBody?.DocumentNode.SelectNodes(xpaths[(int)Constants.JobElement.Main]);

            if (htmlNodes == null)
            {
                return new List<Job>();
            }

            // Iterate through HTML file.
            foreach (var node in htmlNodes)
            {
                var job = new Job(Constants.Grid.MinimumRowHeight);

                var imageNode = node.SelectSingleNode(xpaths[(int)Constants.JobElement.CompanyImage]);
                var urlNode = node.SelectSingleNode(xpaths[(int)Constants.JobElement.Url]);
                var titleNode = node.SelectSingleNode(xpaths[(int)Constants.JobElement.Title]);
                var companyNode = node.SelectSingleNode(xpaths[(int)Constants.JobElement.Company]);
                var postDateNode = node.SelectSingleNode(xpaths[(int)Constants.JobElement.PostDate]);
                var addressNode = node.SelectSingleNode(xpaths[(int)Constants.JobElement.Address]);
                var validDateNode = node.SelectSingleNode(xpaths[(int)Constants.JobElement.ValidDate]);
                var salaryNode = node.SelectSingleNode(xpaths[(int)Constants.JobElement.Salary]);

                if (imageNode != null)
                {
                    job.CompanyImage = GetJobImage(imageNode);
                }
                if (titleNode != null)
                {
                    job.Title = titleNode.InnerText;
                }
                if (urlNode != null)
                {
                    job.Url = urlNode.Attributes[Constants.HtmlAttribute.Href].Value
                        .CustomReplace(Constants.ReplacableStrings);

                    // Scrape description if user selected this option.
                    if (descriptionScraping)
                    {
                        job.Description = GetJobDescription(job.Url, xpaths[(int)Constants.JobElement.Description]);
                    }
                }
                if (companyNode != null)
                {
                    job.Company = companyNode.InnerText;
                }
                if (postDateNode != null)
                {
                    job.PostDate = postDateNode.InnerText;
                }
                if (validDateNode != null)
                {
                    job.ValidUntilDate = validDateNode.InnerText.CustomReplace(Constants.ReplacableStrings);
                }
                if (addressNode != null)
                {
                    job.Address = addressNode.InnerText;
                }
                if (salaryNode != null)
                {
                    job.Salary = salaryNode.InnerText
                        .CustomReplace(Constants.ReplacableStrings)
                        .ReplaceWhiteSpace();
                }

                jobs.Add(job);
            }

            return jobs;
        }

        private static Bitmap GetJobImage(HtmlNode imageNode)
        {
            if (imageNode == null)
            {
                return null;
            }

            var imageUrl = imageNode.Attributes[Constants.HtmlAttribute.Src].Value
                .CustomReplace(Constants.ReplacableStrings);

            return imageUrl.SaveImage();
        }

        public static string GetJobDescription(string url, string xpath)
        {
            var htmlDoc = CustomWebClient.GetHtmlDocument(url);
            var htmlBody = htmlDoc?.DocumentNode.SelectSingleNode(xpath);

            if (htmlDoc == null || htmlBody == null)
            {
                return string.Empty;
            }

            return htmlBody.InnerText.Trim();
        }

        // Initiate scraping procedure.
        public static void StartScraping()
        {
            Website = new Website(Form1.UrlBox.Text);

            do
            {
                var htmlBody = CustomWebClient.GetHtmlDocument(Website.Url.AbsoluteUri);
                var newJobs = GetJobs(htmlBody, Constants.WebsiteXpaths[Website.Url.Host], Options.DescriptionScraping);

                // If we have limited jobs on a website,
                // check if we are not past them.

                if (newJobs.Count == 0)
                {
                    break;
                }
                else if (Website.MaxWebsiteJobs.HasValue)
                {
                    if (Website.MaxWebsiteJobs.Value <= Jobs.Count)
                    {
                        break;
                    }
                }

                // Get the end of the parsing if we know total job count before hand.
                if (Website.MaxWebsiteJobs.HasValue == false && 
                    Website.Url.Host == Constants.Website.CVbankas)
                {
                    Website.MaxWebsiteJobs = GetCVbankasScrapingEnd(htmlBody, 
                        Constants.WebsiteXpaths[Website.Url.Host]);
                }
             
                Jobs.AddRange(newJobs);
                Form1.Grid.Rows.AddRange(newJobs.Select(x => x.GetDataGridViewRow()).ToArray());

                // Increment URL parameter by one.
                Website.Url = Website.Url.IncreaseQueryIntegerValue(Constants.WebsiteParam.Page);

                Statistics.DisplayTotalJobCount(Jobs.Count);
                Thread.Sleep(Constants.SleepTime);
            }
            while (Options.ScrapAllPages);             
        }
        
        // Since CVbankas website has unlimited pagination, we'll need to find the end using
        // the total number of jobs in a particular category.
        private static int? GetCVbankasScrapingEnd(HtmlDocument htmlBody, string[] xpaths)
        {
            var jobCountNode = htmlBody.DocumentNode
                .SelectSingleNode(xpaths[(int)Constants.JobElement.JobCount]);

            if (jobCountNode == null)
            {
                return null;
            }

            var jobCountText = jobCountNode.InnerText;
            var perenthesisIndex = jobCountText.IndexOf(Constants.Character.LeftPerenthesis);
            var numberString = jobCountText.Substring(0, perenthesisIndex).ReplaceNonDigit();

            int.TryParse(numberString, out int number);

            return number;
        }



    }
}