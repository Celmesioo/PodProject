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
            this.cmbBoxInterval = new System.Windows.Forms.ComboBox();
            this.txtBoxNewCategory = new System.Windows.Forms.TextBox();
            this.BtnNewCategory = new System.Windows.Forms.Button();
            this.grpBoxPodPreview = new System.Windows.Forms.GroupBox();
            this.lnkLblDownloadEpisode = new System.Windows.Forms.LinkLabel();
            this.lblEpisodeTitle = new System.Windows.Forms.Label();
            this.BtnDeleteCategory = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.grpBoxPodPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(94, 41);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(417, 20);
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
            this.lblCategory.Location = new System.Drawing.Point(29, 117);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategori:";
            // 
            // cmbBoxCategories
            // 
            this.cmbBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCategories.FormattingEnabled = true;
            this.cmbBoxCategories.Items.AddRange(new object[] {
            "Övrigt"});
            this.cmbBoxCategories.Location = new System.Drawing.Point(94, 117);
            this.cmbBoxCategories.Name = "cmbBoxCategories";
            this.cmbBoxCategories.Size = new System.Drawing.Size(128, 21);
            this.cmbBoxCategories.TabIndex = 5;
            // 
            // lblUpdateInterval
            // 
            this.lblUpdateInterval.AutoSize = true;
            this.lblUpdateInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInterval.Location = new System.Drawing.Point(228, 79);
            this.lblUpdateInterval.Name = "lblUpdateInterval";
            this.lblUpdateInterval.Size = new System.Drawing.Size(178, 17);
            this.lblUpdateInterval.TabIndex = 6;
            this.lblUpdateInterval.Text = "Uppdateringsintervall(min):";
            // 
            // BtnAddRss
            // 
            this.BtnAddRss.Location = new System.Drawing.Point(241, 117);
            this.BtnAddRss.Name = "BtnAddRss";
            this.BtnAddRss.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRss.TabIndex = 7;
            this.BtnAddRss.Text = "Lägg till Podcast";
            this.BtnAddRss.UseVisualStyleBackColor = true;
            this.BtnAddRss.Click += new System.EventHandler(this.BtnAddRss_Click);
            // 
            // treeViewPodcasts
            // 
            this.treeViewPodcasts.Location = new System.Drawing.Point(634, 238);
            this.treeViewPodcasts.Name = "treeViewPodcasts";
            this.treeViewPodcasts.Size = new System.Drawing.Size(454, 277);
            this.treeViewPodcasts.TabIndex = 8;
            this.treeViewPodcasts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPodcasts_AfterSelect);
            // 
            // BtnShowAllPods
            // 
            this.BtnShowAllPods.Location = new System.Drawing.Point(362, 117);
            this.BtnShowAllPods.Name = "BtnShowAllPods";
            this.BtnShowAllPods.Size = new System.Drawing.Size(149, 38);
            this.BtnShowAllPods.TabIndex = 9;
            this.BtnShowAllPods.Text = "Visa samtliga podcasts";
            this.BtnShowAllPods.UseVisualStyleBackColor = true;
            this.BtnShowAllPods.Click += new System.EventHandler(this.BtnShowAllPods_Click);
            // 
            // cmbBoxInterval
            // 
            this.cmbBoxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxInterval.FormattingEnabled = true;
            this.cmbBoxInterval.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60"});
            this.cmbBoxInterval.Location = new System.Drawing.Point(412, 78);
            this.cmbBoxInterval.Name = "cmbBoxInterval";
            this.cmbBoxInterval.Size = new System.Drawing.Size(99, 21);
            this.cmbBoxInterval.TabIndex = 10;
            // 
            // txtBoxNewCategory
            // 
            this.txtBoxNewCategory.Location = new System.Drawing.Point(94, 351);
            this.txtBoxNewCategory.Name = "txtBoxNewCategory";
            this.txtBoxNewCategory.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNewCategory.TabIndex = 11;
            // 
            // BtnNewCategory
            // 
            this.BtnNewCategory.Location = new System.Drawing.Point(200, 349);
            this.BtnNewCategory.Name = "BtnNewCategory";
            this.BtnNewCategory.Size = new System.Drawing.Size(104, 23);
            this.BtnNewCategory.TabIndex = 12;
            this.BtnNewCategory.Text = "Lägg till kategori";
            this.BtnNewCategory.UseVisualStyleBackColor = true;
            this.BtnNewCategory.Click += new System.EventHandler(this.BtnNewCategory_Click);
            // 
            // grpBoxPodPreview
            // 
            this.grpBoxPodPreview.Controls.Add(this.BtnPlay);
            this.grpBoxPodPreview.Controls.Add(this.lnkLblDownloadEpisode);
            this.grpBoxPodPreview.Controls.Add(this.lblEpisodeTitle);
            this.grpBoxPodPreview.Location = new System.Drawing.Point(634, -1);
            this.grpBoxPodPreview.Name = "grpBoxPodPreview";
            this.grpBoxPodPreview.Size = new System.Drawing.Size(466, 239);
            this.grpBoxPodPreview.TabIndex = 13;
            this.grpBoxPodPreview.TabStop = false;
            // 
            // lnkLblDownloadEpisode
            // 
            this.lnkLblDownloadEpisode.AutoSize = true;
            this.lnkLblDownloadEpisode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLblDownloadEpisode.Location = new System.Drawing.Point(310, 206);
            this.lnkLblDownloadEpisode.Name = "lnkLblDownloadEpisode";
            this.lnkLblDownloadEpisode.Size = new System.Drawing.Size(57, 13);
            this.lnkLblDownloadEpisode.TabIndex = 1;
            this.lnkLblDownloadEpisode.TabStop = true;
            this.lnkLblDownloadEpisode.Text = "Ladda Ner";
            this.lnkLblDownloadEpisode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblDownloadEpisode_LinkClicked);
            // 
            // lblEpisodeTitle
            // 
            this.lblEpisodeTitle.AutoSize = true;
            this.lblEpisodeTitle.Location = new System.Drawing.Point(33, 206);
            this.lblEpisodeTitle.Name = "lblEpisodeTitle";
            this.lblEpisodeTitle.Size = new System.Drawing.Size(62, 13);
            this.lblEpisodeTitle.TabIndex = 0;
            this.lblEpisodeTitle.Text = "Avsnitt Titel";
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.Location = new System.Drawing.Point(94, 154);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(100, 23);
            this.BtnDeleteCategory.TabIndex = 14;
            this.BtnDeleteCategory.Text = "Radera kategori";
            this.BtnDeleteCategory.UseVisualStyleBackColor = true;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(373, 201);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.Text = "Spela upp";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 527);
            this.Controls.Add(this.BtnDeleteCategory);
            this.Controls.Add(this.grpBoxPodPreview);
            this.Controls.Add(this.BtnNewCategory);
            this.Controls.Add(this.txtBoxNewCategory);
            this.Controls.Add(this.cmbBoxInterval);
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
            this.grpBoxPodPreview.ResumeLayout(false);
            this.grpBoxPodPreview.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbBoxInterval;
        private System.Windows.Forms.TextBox txtBoxNewCategory;
        private System.Windows.Forms.Button BtnNewCategory;
        private System.Windows.Forms.GroupBox grpBoxPodPreview;
        private System.Windows.Forms.LinkLabel lnkLblDownloadEpisode;
        private System.Windows.Forms.Label lblEpisodeTitle;
        private System.Windows.Forms.Button BtnDeleteCategory;
        private System.Windows.Forms.Button BtnPlay;
    }
}

