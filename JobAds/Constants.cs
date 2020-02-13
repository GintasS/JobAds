using System;
using System.Collections.Generic;

namespace JobAds
{
    // Class, that holds all the needed constants for this app.
    public static class Constants
    {
        public struct Website
        {
            public static string CVonline = "www.cvonline.lt";
            public static string CVbankas = "www.cvbankas.lt";
        };

        /* XPath structure:
           [0] => XPath selector for every job item in html website.
           [1] => XPath selector for current job's company image.
           [2] => XPath selector for current job's posting url.
           [3] => XPath selector for current job's title.
           [4] => XPath selector for current job's company.
           [5] => XPath selector for current job's post date.
           [6] => XPath selector for current job's address.
           [7] => XPath selector for current job's valid date (optional).
           [8] => XPath selector for current job's salary (optional).
           [9] => XPath selector for current job's posting inside description.
           [10] => XPath selector for a number of jobs (optional).
        */
        public static Dictionary<string, string[]> WebsiteXpaths
        {
            get => new Dictionary<string, string[]>()
            {
                { Website.CVonline, new string[] 
                    {
                        /* [0] */ "//div[@id='joblist']//div[@itemtype='http://schema.org/JobPosting']",
                        /* [1] */ ".//a//img",
                        /* [2] */ ".//a[@itemprop='title']",
                        /* [3] */ ".//a[@itemprop='title']",
                        /* [4] */ ".//span[@itemprop='hiringOrganization']",
                        /* [5] */ ".//span[@itemprop='datePosted']",
                        /* [6] */ ".//span[@itemprop='jobLocation']",
                        /* [7] */ ".//div[@itemprop='description']//ul/li/text()[last()]",
                        /* [8] */ ".//span[@class='salary-blue']",
                        /* [9] */ "//div[@itemtype='http://schema.org/JobPosting']",
                        /* [10]*/ ".//html"
                    }
                },
                { Website.CVbankas, new string[] 
                    {         
                        /* [0] */ "//div[@id='job_ad_list']//article",
                        /* [1] */ ".//div[@class='list_logo_c']//img",
                        /* [2] */ ".//a[@class='list_a can_visited list_a_has_logo']",
                        /* [3] */ ".//a[@class='list_a can_visited list_a_has_logo']//h3",
                        /* [4] */ ".//span[@class='dib mt5']",
                        /* [5] */ ".//span[@class='txt_list_2']",
                        /* [6] */ ".//span[@class='list_city']",
                        /* [7] */ ".//html",
                        /* [8] */ ".//span[@class='salary_text']",
                        /* [9] */ "//div[@id='jobad_content_main']",
                        /* [10]*/ "//form/span"
                    }
                }
            };
        }
            
        public static string[][] ReplacableStrings
        {
            get => new string[][]
            {
                new string[] { "Prašymus siųskite iki", string.Empty, string.Empty },
                new string[] { "Metinis atlyginimas:", string.Empty, " per year" },
                new string[] { "Mėnesinis atlygis ", string.Empty," per month" },
                new string[] { "Valandinis atlygis:", string.Empty, " per hour" },
                new string[] { "Prašymus siųskite iki ", string.Empty, string.Empty },
                new string[] { "(bruto):", string.Empty, " (bruto)" },
                new string[] { "(neto):", string.Empty, " (neto)" },
                new string[] { "//", "http://", string.Empty },
                new string[] { Environment.NewLine, string.Empty, string.Empty}
            };
        }

        public struct Grid
        {
            public static int MinimumRowHeight = 80;
        }

        // Params are used to identify on what page number we are currently on.
        public struct WebsiteParam
        {
            public static string QuestionPage = "?page=";
            public static string AndPage = "&page=";
            public static string Page = "page";
        }

        public struct HtmlAttribute
        {
            public static string Href = "href";
            public static string Src = "src";
        }

        public struct Character
        {
            public static string Dash = "-";
            public static string Space = " ";
            public static string One = "1";
            public static string LeftPerenthesis = "(";
        }

        public struct Regex
        {
            public static string WhitespaceReplace = @"\s\s+";
            public static string CVonlineUrl = @"((https:\/\/)|(http:\/\/))(www.)(cvonline\.lt)(.*)";
            public static string CVbankasUrl = @"((https:\/\/)|(http:\/\/))(www.)(cvbankas\.lt)(.*)";
            public static string NonDigits = @"[^\d]";
        }

        public static int SleepTime = 1000;

        public enum JobElement
        {
            Main, CompanyImage, Url, Title, Company, PostDate, Address, ValidDate, Salary, Description, JobCount
        }

        public struct UserMessage
        {
            public static string Failed = "We failed to fetch data from one of the portals, please try again later.";
        }



    }
}