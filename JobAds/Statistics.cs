using System.Windows.Forms;

namespace JobAds
{
    // Class, that handles statistics.
    public static class Statistics
    {
        public static Label TotalResultsLabel { private get; set; }
        public static Label SearchResultsLabel { private get; set; }

        // Method, that displays the number of search results to the user.
        public static void DisplaySearchCount(int searchCount)
        {
            SearchResultsLabel.Text = searchCount.ToString();
            SearchResultsLabel.Update();
        }

        // Method, that displays the number of total jobs to the user.
        public static void DisplayTotalJobCount(int jobsCount)
        {
            TotalResultsLabel.Text = jobsCount.ToString();
            TotalResultsLabel.Update();
        }



    }
}