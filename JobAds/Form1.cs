using System;
using System.Windows.Forms;

namespace JobAds
{
    public partial class Form1 : Form
    {
        public static DataGridView Grid { get; private set; }

        // Buttons.
        public static Button StartButton { get; private set; }
        public static Button CleanButton { get; private set; }

        // Text boxes.
        public static TextBox UrlBox { get; private set; }
        public static TextBox SearchBox { get; private set; }

        // Check boxes.
        public static CheckBox AllPagesCheckBox { get; private set; }
        public static CheckBox DescriptionScraping { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeStatisticsControls();
            InitializeControls();
            InitializeEvents();
        }

        // Method, that initializes statistics data.
        private void InitializeStatisticsControls()
        {
            Statistics.TotalResultsLabel = totalResultsLabel;
            Statistics.SearchResultsLabel = searchResultLabel;
        }

        // Method, that initializes control data.
        private void InitializeControls()
        {
            UrlBox = urlBox;
            SearchBox = searchBox;
            Grid = dataGridView1;

            StartButton = StartBTN;
            CleanButton = CleanBTN;

            DescriptionScraping = DescriptionScrapingCheckBox;
            AllPagesCheckBox = allPagesCheckBox;

            CleanButton.Enabled = false;
            searchBox.Enabled = false;
        }

        // Method, that initializes button data.
        private void InitializeEvents()
        {
            StartBTN.Click += CustomEvents.StartScraping;
            CleanBTN.Click += CustomEvents.CleanJobs;
            UrlBox.TextChanged += CustomEvents.UrlBoxOnTextChange;
            SearchBox.TextChanged += CustomEvents.SearchOnTextChange;
            Grid.SelectionChanged += CustomEvents.OnRowClick;
        }



    }
}