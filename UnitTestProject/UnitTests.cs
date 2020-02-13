using System.IO;
using System.Linq;
using HtmlAgilityPack;
using JobAds;
using JobAds.Extensions;
using JobAds.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        [DeploymentItem("Test files\\test.html")]
        public void TestGetSingleJobCVonline()
        {
            string testData = File.ReadAllText(@"test.html");
            var testDocument = new HtmlDocument();
            testDocument.LoadHtml(testData);

            var expected = new Job(Constants.Grid.MinimumRowHeight)
            {
                Company = "Gintas, UAB",
                PostDate = "Prieš 20 val.",
                ValidUntilDate = "2020.02.25",
                Address = "Ukmergės g. 322, Vilnius",
                Salary = "Nuo 2000.00 iki 3400.00 EUR per month (bruto)",
                CompanyImage = "https://i.ytimg.com/vi/J3pF2jkQ4vc/maxresdefault.jpg".SaveImage(),
                Title = "JAVA SOFTWARE ENGINEER",
                Url = "http://www.cvonline.lt/darbo-skelbimas/gintas-uab/java-software-engineer.html"
            };

            var actual = JobScraper.GetJobs(testDocument, Constants.WebsiteXpaths[Constants.Website.CVonline], false)
                .FirstOrDefault();

            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        [DeploymentItem("Test files\\test2.html")]
        public void TestGetSingleJobCVbankas()
        {
            string testData = File.ReadAllText(@"test2.html");
            var testDocument = new HtmlDocument();
            testDocument.LoadHtml(testData);

            var expected = new Job(Constants.Grid.MinimumRowHeight)
            {
                Company = "Test",
                PostDate = "prieš 6 min.",
                Address = "Islandijoje",
                Salary = "Nuo 3015 €/mėn.",
                CompanyImage = "https://i.ytimg.com/vi/J3pF2jkQ4vc/maxresdefault.jpg".SaveImage(),
                Title = "Santechnikas",
                Url = "https://www.cvbankas.lt/santechnikas/"
            };

            var actual = JobScraper.GetJobs(testDocument, Constants.WebsiteXpaths[Constants.Website.CVbankas], false)
                .FirstOrDefault();

            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        [DeploymentItem("Helper files\\helper3.txt")]
        public void TestGetJobDescription()
        {
            var expected = File.ReadAllText(@"helper3.txt");
            var actual = JobScraper.GetJobDescription("https://www.lipsum.com/", ".//h1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidateWebsiteUrlCVonline()
        {
            Assert.IsTrue(Website.IsValidUrl("https://www.cvonline.lt/darbo-skelbimai/finansai-apskaita/vilniaus?page=1"));
        }

        [TestMethod]
        public void TestValidateWebsiteUrlCVbankas()
        {
            Assert.IsTrue(Website.IsValidUrl("https://www.cvbankas.lt/?miestas=Vilnius&page=1"));
        }



    }
}