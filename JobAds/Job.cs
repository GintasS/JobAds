using JobAds.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobAds.Models
{
    // Instance class that will hold data about a single job.
    public class Job
    {
        public string Company { private get; set; } = Constants.Character.Dash;
        public string PostDate { private get; set; } = Constants.Character.Dash;
        public string ValidUntilDate { private get; set; } = Constants.Character.Dash;
        public string Address { private get; set; } = Constants.Character.Dash;
        public string Salary { private get; set; } = Constants.Character.Dash;
        public Bitmap CompanyImage { private get; set; }
        public string Title { private get; set; } = Constants.Character.Dash;
        public string Url { get; set; } = Constants.Character.Dash;
        public string Description { private get; set; } = Constants.Character.Dash;
        public DataGridViewRow JobRow { get; private set; }

        public Job(int minimumRowHeight)
        {
            JobRow = new DataGridViewRow();
            JobRow.MinimumHeight = minimumRowHeight;
        }

        // Method, that returns job row to the grid.
        public DataGridViewRow GetDataGridViewRow()
        {
            JobRow.CreateCells(
                Form1.Grid,
                CompanyImage, 
                Title, 
                Company,
                PostDate, 
                ValidUntilDate,
                Address, 
                Salary, 
                Url
            );

            return JobRow;
        }

        // Method that will search for a needle in a job.
        public bool Search(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return true;
            }

            var stringComparer = StringComparison.OrdinalIgnoreCase;

            return Title.IndexOf(text, stringComparer) >= 0 ||
                Company.IndexOf(text, stringComparer) >= 0 ||
                Address.IndexOf(text, stringComparer) >= 0 ||
                Description.IndexOf(text, stringComparer) >= 0;
        }

        // Method to compare two jobs for unit tests.
        public bool Equals(Job job)
        {
            if (job == null)
            {
                return false;
            }

            return Company == job.Company &&
                PostDate == job.PostDate &&
                ValidUntilDate == job.ValidUntilDate &&
                Address == job.Address &&
                Salary == job.Salary &&
                CompanyImage.CompareBitmapsFast(job.CompanyImage) && 
                Title == job.Title &&
                Url == job.Url &&
                Description == job.Description;
        }



    }
}