namespace JobAds
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DescriptionScrapingCheckBox = new System.Windows.Forms.CheckBox();
            this.allPagesCheckBox = new System.Windows.Forms.CheckBox();
            this.totalResultsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CleanBTN = new System.Windows.Forms.Button();
            this.StartBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.JobImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobPostDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobValidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Company Image:";
            this.dataGridViewImageColumn1.Image = global::JobAds.Properties.Resources.white;
            this.dataGridViewImageColumn1.MinimumWidth = 70;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DescriptionScrapingCheckBox);
            this.tabPage1.Controls.Add(this.allPagesCheckBox);
            this.tabPage1.Controls.Add(this.totalResultsLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.searchResultLabel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.urlBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CleanBTN);
            this.tabPage1.Controls.Add(this.StartBTN);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1377, 782);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jobs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DescriptionScrapingCheckBox
            // 
            this.DescriptionScrapingCheckBox.AutoSize = true;
            this.DescriptionScrapingCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DescriptionScrapingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionScrapingCheckBox.Location = new System.Drawing.Point(359, 734);
            this.DescriptionScrapingCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionScrapingCheckBox.Name = "DescriptionScrapingCheckBox";
            this.DescriptionScrapingCheckBox.Size = new System.Drawing.Size(262, 28);
            this.DescriptionScrapingCheckBox.TabIndex = 14;
            this.DescriptionScrapingCheckBox.TabStop = false;
            this.DescriptionScrapingCheckBox.Text = "Enable description scraping";
            this.DescriptionScrapingCheckBox.UseVisualStyleBackColor = true;
            // 
            // allPagesCheckBox
            // 
            this.allPagesCheckBox.AutoSize = true;
            this.allPagesCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allPagesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allPagesCheckBox.Location = new System.Drawing.Point(184, 734);
            this.allPagesCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allPagesCheckBox.Name = "allPagesCheckBox";
            this.allPagesCheckBox.Size = new System.Drawing.Size(157, 28);
            this.allPagesCheckBox.TabIndex = 13;
            this.allPagesCheckBox.TabStop = false;
            this.allPagesCheckBox.Text = "Scrap all pages";
            this.allPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalResultsLabel
            // 
            this.totalResultsLabel.AutoSize = true;
            this.totalResultsLabel.Location = new System.Drawing.Point(1293, 15);
            this.totalResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalResultsLabel.Name = "totalResultsLabel";
            this.totalResultsLabel.Size = new System.Drawing.Size(20, 24);
            this.totalResultsLabel.TabIndex = 10;
            this.totalResultsLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1181, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total jobs:";
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(1293, 60);
            this.searchResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(20, 24);
            this.searchResultLabel.TabIndex = 8;
            this.searchResultLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1141, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search results:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(111, 57);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(735, 28);
            this.searchBox.TabIndex = 6;
            this.searchBox.TabStop = false;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(111, 11);
            this.urlBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(735, 28);
            this.urlBox.TabIndex = 3;
            this.urlBox.TabStop = false;
            this.urlBox.Text = "https://www.cvonline.lt/darbo-skelbimai/informacines-technologijos/vilniaus?page=" +
    "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start url:";
            // 
            // CleanBTN
            // 
            this.CleanBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanBTN.Location = new System.Drawing.Point(1201, 722);
            this.CleanBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CleanBTN.Name = "CleanBTN";
            this.CleanBTN.Size = new System.Drawing.Size(160, 47);
            this.CleanBTN.TabIndex = 2;
            this.CleanBTN.TabStop = false;
            this.CleanBTN.Text = "Clean";
            this.CleanBTN.UseVisualStyleBackColor = true;
            // 
            // StartBTN
            // 
            this.StartBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBTN.Location = new System.Drawing.Point(16, 722);
            this.StartBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(160, 47);
            this.StartBTN.TabIndex = 1;
            this.StartBTN.TabStop = false;
            this.StartBTN.Text = "Start:";
            this.StartBTN.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobImage,
            this.JobTitle,
            this.JobCompanyName,
            this.JobPostDate,
            this.JobValidDate,
            this.JobAddress,
            this.JobSalary,
            this.JobUrl});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(16, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 602);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // JobImage
            // 
            this.JobImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle17.NullValue")));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.JobImage.DefaultCellStyle = dataGridViewCellStyle17;
            this.JobImage.FillWeight = 80F;
            this.JobImage.HeaderText = "";
            this.JobImage.Image = global::JobAds.Properties.Resources.white;
            this.JobImage.MinimumWidth = 60;
            this.JobImage.Name = "JobImage";
            this.JobImage.ReadOnly = true;
            this.JobImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.JobImage.Width = 125;
            // 
            // JobTitle
            // 
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobTitle.DefaultCellStyle = dataGridViewCellStyle18;
            this.JobTitle.HeaderText = "Title";
            this.JobTitle.MinimumWidth = 200;
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.ReadOnly = true;
            this.JobTitle.Width = 200;
            // 
            // JobCompanyName
            // 
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobCompanyName.DefaultCellStyle = dataGridViewCellStyle19;
            this.JobCompanyName.HeaderText = "Company";
            this.JobCompanyName.MinimumWidth = 150;
            this.JobCompanyName.Name = "JobCompanyName";
            this.JobCompanyName.ReadOnly = true;
            this.JobCompanyName.Width = 150;
            // 
            // JobPostDate
            // 
            dataGridViewCellStyle20.Format = "d";
            dataGridViewCellStyle20.NullValue = null;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobPostDate.DefaultCellStyle = dataGridViewCellStyle20;
            this.JobPostDate.HeaderText = "Post date";
            this.JobPostDate.MinimumWidth = 6;
            this.JobPostDate.Name = "JobPostDate";
            this.JobPostDate.ReadOnly = true;
            this.JobPostDate.Width = 120;
            // 
            // JobValidDate
            // 
            dataGridViewCellStyle21.Format = "d";
            dataGridViewCellStyle21.NullValue = null;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobValidDate.DefaultCellStyle = dataGridViewCellStyle21;
            this.JobValidDate.HeaderText = "Valid until";
            this.JobValidDate.MinimumWidth = 6;
            this.JobValidDate.Name = "JobValidDate";
            this.JobValidDate.ReadOnly = true;
            this.JobValidDate.Width = 120;
            // 
            // JobAddress
            // 
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobAddress.DefaultCellStyle = dataGridViewCellStyle22;
            this.JobAddress.HeaderText = "Address";
            this.JobAddress.MinimumWidth = 120;
            this.JobAddress.Name = "JobAddress";
            this.JobAddress.ReadOnly = true;
            this.JobAddress.Width = 120;
            // 
            // JobSalary
            // 
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobSalary.DefaultCellStyle = dataGridViewCellStyle23;
            this.JobSalary.HeaderText = "Salary";
            this.JobSalary.MinimumWidth = 150;
            this.JobSalary.Name = "JobSalary";
            this.JobSalary.ReadOnly = true;
            this.JobSalary.Width = 150;
            // 
            // JobUrl
            // 
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobUrl.DefaultCellStyle = dataGridViewCellStyle24;
            this.JobUrl.HeaderText = "Url";
            this.JobUrl.MinimumWidth = 150;
            this.JobUrl.Name = "JobUrl";
            this.JobUrl.ReadOnly = true;
            this.JobUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.JobUrl.Visible = false;
            this.JobUrl.Width = 150;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1385, 820);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 820);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Job Ads";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox DescriptionScrapingCheckBox;
        private System.Windows.Forms.CheckBox allPagesCheckBox;
        private System.Windows.Forms.Label totalResultsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CleanBTN;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewImageColumn JobImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPostDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobValidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobUrl;
    }
}

