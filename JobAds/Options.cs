using System.Windows.Forms;

namespace JobAds
{
    // Class, that handles options.
    public static class Options
    {
        public static bool ScrapAllPages { get; private set; }
        public static bool DescriptionScraping { get; private set; }

        // Method, that detects user selected options.
        public static void DetectOptions()
        {
            ScrapAllPages = Form1.AllPagesCheckBox.CheckState == CheckState.Checked;
            DescriptionScraping = Form1.DescriptionScraping.CheckState == CheckState.Checked;
        }



    }
}