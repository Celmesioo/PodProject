namespace UserInterface
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
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxRssName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbBoxCategories = new System.Windows.Forms.ComboBox();
            this.lblUpdateInterval = new System.Windows.Forms.Label();
            this.BtnAddRss = new System.Windows.Forms.Button();
            this.treeViewPodcasts = new System.Windows.Forms.TreeView();
            this.BtnShowAllPods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(94, 41);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(367, 20);
            this.txtBoxUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(29, 42);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(59, 17);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Rss-Url:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(29, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Namn:";
            // 
            // txtBoxRssName
            // 
            this.txtBoxRssName.Location = new System.Drawing.Point(94, 77);
            this.txtBoxRssName.Name = "txtBoxRssName";
            this.txtBoxRssName.Size = new System.Drawing.Size(128, 20);
            this.txtBoxRssName.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(29, 126);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategori:";
            // 
            // cmbBoxCategories
            // 
            this.cmbBoxCategories.FormattingEnabled = true;
            this.cmbBoxCategories.Items.AddRange(new object[] {
            "Musik",
            "Nöje",
            "Programmering"});
            this.cmbBoxCategories.Location = new System.Drawing.Point(94, 122);
            this.cmbBoxCategories.Name = "cmbBoxCategories";
            this.cmbBoxCategories.Size = new System.Drawing.Size(128, 21);
            this.cmbBoxCategories.TabIndex = 5;
            // 
            // lblUpdateInterval
            // 
            this.lblUpdateInterval.AutoSize = true;
            this.lblUpdateInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInterval.Location = new System.Drawing.Point(240, 78);
            this.lblUpdateInterval.Name = "lblUpdateInterval";
            this.lblUpdateInterval.Size = new System.Drawing.Size(146, 17);
            this.lblUpdateInterval.TabIndex = 6;
            this.lblUpdateInterval.Text = "Uppdateringsintervall:";
            // 
            // BtnAddRss
            // 
            this.BtnAddRss.Location = new System.Drawing.Point(252, 122);
            this.BtnAddRss.Name = "BtnAddRss";
            this.BtnAddRss.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRss.TabIndex = 7;
            this.BtnAddRss.Text = "Lägg till Podcast";
            this.BtnAddRss.UseVisualStyleBackColor = true;
            this.BtnAddRss.Click += new System.EventHandler(this.BtnAddRss_Click);
            // 
            // treeViewPodcasts
            // 
            this.treeViewPodcasts.Location = new System.Drawing.Point(634, 12);
            this.treeViewPodcasts.Name = "treeViewPodcasts";
            this.treeViewPodcasts.Size = new System.Drawing.Size(454, 503);
            this.treeViewPodcasts.TabIndex = 8;
            // 
            // BtnShowAllPods
            // 
            this.BtnShowAllPods.Location = new System.Drawing.Point(94, 374);
            this.BtnShowAllPods.Name = "BtnShowAllPods";
            this.BtnShowAllPods.Size = new System.Drawing.Size(149, 38);
            this.BtnShowAllPods.TabIndex = 9;
            this.BtnShowAllPods.Text = "Visa samtliga podcasts";
            this.BtnShowAllPods.UseVisualStyleBackColor = true;
            this.BtnShowAllPods.Click += new System.EventHandler(this.BtnShowAllPods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 527);
            this.Controls.Add(this.BtnShowAllPods);
            this.Controls.Add(this.treeViewPodcasts);
            this.Controls.Add(this.BtnAddRss);
            this.Controls.Add(this.lblUpdateInterval);
            this.Controls.Add(this.cmbBoxCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtBoxRssName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtBoxUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxRssName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbBoxCategories;
        private System.Windows.Forms.Label lblUpdateInterval;
        private System.Windows.Forms.Button BtnAddRss;
        private System.Windows.Forms.TreeView treeViewPodcasts;
        private System.Windows.Forms.Button BtnShowAllPods;
    }
}

