using System;
using System.Linq;
using System.Windows.Forms;
using JobAds.Models;

namespace JobAds
{
    // Class, that handles all user clicks/textbox edits.
    public static class CustomEvents
    {
        // Method, that handles 'Start' button click event.
        public static void StartScraping(object sender, EventArgs e)
        {
            Form1.StartButton.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            Options.DetectOptions();

            JobScraper.StartScraping();

            Cursor.Current = Cursors.Hand;

            // If we didn't get any results, clean data.
            if (Form1.Grid.RowCount > 0)
            {
                Form1.CleanButton.Enabled = true;
                Form1.SearchBox.Enabled = true;
                Form1.AllPagesCheckBox.Enabled = false;
                Form1.DescriptionScraping.Enabled = false;
                Form1.UrlBox.Enabled = false;
            }
            else
            {
                MessageBox.Show(Constants.UserMessage.Failed);
                CleanJobs(null, null);
            }
        }

        // Method, that handles 'Clean' button click event.
        public static void CleanJobs(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Method, that handles text change on url text box.
        public static void UrlBoxOnTextChange(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            Form1.StartButton.Enabled = Website.IsValidUrl(box.Text);
        }

        // Reset all jobs to be seen when search box is empty.
        public static void SearchOnTextChange(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                JobScraper.Jobs.ForEach(c => c.JobRow.Visible = true);
                Statistics.DisplaySearchCount(0);

                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            JobScraper.Jobs.ForEach(x => x.JobRow.Visible = x.Search(box.Text));
            Statistics.DisplaySearchCount(JobScraper.Jobs.Count(x => x.JobRow.Visible));

            Cursor.Current = Cursors.Hand;
        }

        // Method, that copies job url to clipboard on row click.
        public static void OnRowClick(object sender, EventArgs e)
        {
            DataGridView view = sender as DataGridView;

            foreach (DataGridViewRow row in view.SelectedRows)
            {
                Clipboard.SetText(row.Cells[7].Value.ToString());
            }
        }



    }
}