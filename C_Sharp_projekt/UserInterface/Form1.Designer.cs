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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.BtnDeleteCategory = new System.Windows.Forms.Button();
            this.cmbBoxFilterByCategory = new System.Windows.Forms.ComboBox();
            this.BtnFilterByCategory = new System.Windows.Forms.Button();
            this.tbEpisodeInfo = new System.Windows.Forms.TabPage();
            this.checkBoxHasListenTo = new System.Windows.Forms.CheckBox();
            this.lblEpisodeTitle = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.lnkLblDownloadEpisode = new System.Windows.Forms.LinkLabel();
            this.tbPodInfo = new System.Windows.Forms.TabPage();
            this.BtnEditPod = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblpodcast = new System.Windows.Forms.Label();
            this.tbCntrPod = new System.Windows.Forms.TabControl();
            this.pnlEditPod = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.cmbBoxNewInterval = new System.Windows.Forms.ComboBox();
            this.cmbBoxNewCategory = new System.Windows.Forms.ComboBox();
            this.txtBoxNewUrl = new System.Windows.Forms.TextBox();
            this.cmbBoxCategoryDeleteOrEdit = new System.Windows.Forms.ComboBox();
            this.BtnEditCategory = new System.Windows.Forms.Button();
            this.pnlEditCategory = new System.Windows.Forms.Panel();
            this.BtnCancelCategory = new System.Windows.Forms.Button();
            this.BtnSaveCategory = new System.Windows.Forms.Button();
            this.txtBoxNewCategoryName = new System.Windows.Forms.TextBox();
            this.tbEpisodeInfo.SuspendLayout();
            this.tbPodInfo.SuspendLayout();
            this.tbCntrPod.SuspendLayout();
            this.pnlEditPod.SuspendLayout();
            this.pnlEditCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(94, 42);
            this.txtBoxUrl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(417, 20);
            this.txtBoxUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(29, 42);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Namn:";
            // 
            // txtBoxRssName
            // 
            this.txtBoxRssName.Location = new System.Drawing.Point(94, 77);
            this.txtBoxRssName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxRssName.Name = "txtBoxRssName";
            this.txtBoxRssName.Size = new System.Drawing.Size(128, 20);
            this.txtBoxRssName.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(29, 117);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategori:";
            // 
            // cmbBoxCategories
            // 
            this.cmbBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCategories.FormattingEnabled = true;
            this.cmbBoxCategories.Location = new System.Drawing.Point(94, 117);
            this.cmbBoxCategories.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbBoxCategories.Name = "cmbBoxCategories";
            this.cmbBoxCategories.Size = new System.Drawing.Size(128, 21);
            this.cmbBoxCategories.TabIndex = 5;
            // 
            // lblUpdateInterval
            // 
            this.lblUpdateInterval.AutoSize = true;
            this.lblUpdateInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInterval.Location = new System.Drawing.Point(228, 79);
            this.lblUpdateInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateInterval.Name = "lblUpdateInterval";
            this.lblUpdateInterval.Size = new System.Drawing.Size(178, 17);
            this.lblUpdateInterval.TabIndex = 6;
            this.lblUpdateInterval.Text = "Uppdateringsintervall(min):";
            // 
            // BtnAddRss
            // 
            this.BtnAddRss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddRss.Location = new System.Drawing.Point(241, 117);
            this.BtnAddRss.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnAddRss.Name = "BtnAddRss";
            this.BtnAddRss.Size = new System.Drawing.Size(76, 24);
            this.BtnAddRss.TabIndex = 7;
            this.BtnAddRss.Text = "Lägg till Podcast";
            this.BtnAddRss.UseVisualStyleBackColor = true;
            this.BtnAddRss.Click += new System.EventHandler(this.BtnAddRss_Click);
            // 
            // treeViewPodcasts
            // 
            this.treeViewPodcasts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewPodcasts.Location = new System.Drawing.Point(634, 247);
            this.treeViewPodcasts.Margin = new System.Windows.Forms.Padding(4, 10, 4, 2);
            this.treeViewPodcasts.Name = "treeViewPodcasts";
            this.treeViewPodcasts.Size = new System.Drawing.Size(460, 236);
            this.treeViewPodcasts.TabIndex = 8;
            this.treeViewPodcasts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPodcasts_AfterSelect);
            // 
            // BtnShowAllPods
            // 
            this.BtnShowAllPods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowAllPods.Location = new System.Drawing.Point(875, 487);
            this.BtnShowAllPods.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnShowAllPods.Name = "BtnShowAllPods";
            this.BtnShowAllPods.Size = new System.Drawing.Size(149, 21);
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
            this.cmbBoxInterval.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbBoxInterval.Name = "cmbBoxInterval";
            this.cmbBoxInterval.Size = new System.Drawing.Size(99, 21);
            this.cmbBoxInterval.TabIndex = 10;
            // 
            // txtBoxNewCategory
            // 
            this.txtBoxNewCategory.Location = new System.Drawing.Point(32, 475);
            this.txtBoxNewCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxNewCategory.Name = "txtBoxNewCategory";
            this.txtBoxNewCategory.Size = new System.Drawing.Size(120, 20);
            this.txtBoxNewCategory.TabIndex = 11;
            // 
            // BtnNewCategory
            // 
            this.BtnNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewCategory.Location = new System.Drawing.Point(160, 470);
            this.BtnNewCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnNewCategory.Name = "BtnNewCategory";
            this.BtnNewCategory.Size = new System.Drawing.Size(104, 24);
            this.BtnNewCategory.TabIndex = 12;
            this.BtnNewCategory.Text = "Lägg till kategori";
            this.BtnNewCategory.UseVisualStyleBackColor = true;
            this.BtnNewCategory.Click += new System.EventHandler(this.BtnNewCategory_Click);
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteCategory.Location = new System.Drawing.Point(238, 400);
            this.BtnDeleteCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(73, 24);
            this.BtnDeleteCategory.TabIndex = 14;
            this.BtnDeleteCategory.Text = "Radera";
            this.BtnDeleteCategory.UseVisualStyleBackColor = true;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // cmbBoxFilterByCategory
            // 
            this.cmbBoxFilterByCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFilterByCategory.FormattingEnabled = true;
            this.cmbBoxFilterByCategory.Location = new System.Drawing.Point(634, 487);
            this.cmbBoxFilterByCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbBoxFilterByCategory.Name = "cmbBoxFilterByCategory";
            this.cmbBoxFilterByCategory.Size = new System.Drawing.Size(120, 21);
            this.cmbBoxFilterByCategory.TabIndex = 15;
            // 
            // BtnFilterByCategory
            // 
            this.BtnFilterByCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFilterByCategory.Location = new System.Drawing.Point(761, 487);
            this.BtnFilterByCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnFilterByCategory.Name = "BtnFilterByCategory";
            this.BtnFilterByCategory.Size = new System.Drawing.Size(108, 24);
            this.BtnFilterByCategory.TabIndex = 16;
            this.BtnFilterByCategory.Text = "Visa inom kategori";
            this.BtnFilterByCategory.UseVisualStyleBackColor = true;
            this.BtnFilterByCategory.Click += new System.EventHandler(this.BtnFilterByCategory_Click);
            // 
            // tbEpisodeInfo
            // 
            this.tbEpisodeInfo.Controls.Add(this.checkBoxHasListenTo);
            this.tbEpisodeInfo.Controls.Add(this.lblEpisodeTitle);
            this.tbEpisodeInfo.Controls.Add(this.BtnPlay);
            this.tbEpisodeInfo.Controls.Add(this.lnkLblDownloadEpisode);
            this.tbEpisodeInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbEpisodeInfo.Location = new System.Drawing.Point(4, 22);
            this.tbEpisodeInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbEpisodeInfo.Name = "tbEpisodeInfo";
            this.tbEpisodeInfo.Size = new System.Drawing.Size(452, 206);
            this.tbEpisodeInfo.TabIndex = 2;
            this.tbEpisodeInfo.Text = "Avsnitt Info";
            this.tbEpisodeInfo.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasListenTo
            // 
            this.checkBoxHasListenTo.AutoSize = true;
            this.checkBoxHasListenTo.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxHasListenTo.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.checkBoxHasListenTo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LawnGreen;
            this.checkBoxHasListenTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHasListenTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHasListenTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxHasListenTo.Location = new System.Drawing.Point(349, 8);
            this.checkBoxHasListenTo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBoxHasListenTo.Name = "checkBoxHasListenTo";
            this.checkBoxHasListenTo.Size = new System.Drawing.Size(83, 17);
            this.checkBoxHasListenTo.TabIndex = 3;
            this.checkBoxHasListenTo.Text = "Uppspelad";
            this.checkBoxHasListenTo.UseVisualStyleBackColor = false;
            // 
            // lblEpisodeTitle
            // 
            this.lblEpisodeTitle.AutoSize = true;
            this.lblEpisodeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodeTitle.Location = new System.Drawing.Point(12, 12);
            this.lblEpisodeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodeTitle.Name = "lblEpisodeTitle";
            this.lblEpisodeTitle.Size = new System.Drawing.Size(80, 15);
            this.lblEpisodeTitle.TabIndex = 0;
            this.lblEpisodeTitle.Text = "Avsnitt Titel";
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnPlay.FlatAppearance.BorderSize = 2;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Font = new System.Drawing.Font("Eras Light ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnPlay.Location = new System.Drawing.Point(349, 31);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Padding = new System.Windows.Forms.Padding(1);
            this.BtnPlay.Size = new System.Drawing.Size(90, 29);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.Text = "Spela upp";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lnkLblDownloadEpisode
            // 
            this.lnkLblDownloadEpisode.AutoSize = true;
            this.lnkLblDownloadEpisode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLblDownloadEpisode.Location = new System.Drawing.Point(22, 71);
            this.lnkLblDownloadEpisode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLblDownloadEpisode.Name = "lnkLblDownloadEpisode";
            this.lnkLblDownloadEpisode.Size = new System.Drawing.Size(57, 13);
            this.lnkLblDownloadEpisode.TabIndex = 1;
            this.lnkLblDownloadEpisode.TabStop = true;
            this.lnkLblDownloadEpisode.Text = "Ladda Ner";
            this.lnkLblDownloadEpisode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblDownloadEpisode_LinkClicked);
            // 
            // tbPodInfo
            // 
            this.tbPodInfo.Controls.Add(this.BtnEditPod);
            this.tbPodInfo.Controls.Add(this.lblDescription);
            this.tbPodInfo.Controls.Add(this.lblpodcast);
            this.tbPodInfo.Location = new System.Drawing.Point(4, 22);
            this.tbPodInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbPodInfo.Name = "tbPodInfo";
            this.tbPodInfo.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbPodInfo.Size = new System.Drawing.Size(452, 206);
            this.tbPodInfo.TabIndex = 0;
            this.tbPodInfo.Text = "Pod Info";
            this.tbPodInfo.UseVisualStyleBackColor = true;
            // 
            // BtnEditPod
            // 
            this.BtnEditPod.Location = new System.Drawing.Point(332, 7);
            this.BtnEditPod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnEditPod.Name = "BtnEditPod";
            this.BtnEditPod.Size = new System.Drawing.Size(76, 24);
            this.BtnEditPod.TabIndex = 7;
            this.BtnEditPod.Text = "Ändra";
            this.BtnEditPod.UseVisualStyleBackColor = true;
            this.BtnEditPod.Click += new System.EventHandler(this.BtnEditPod_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 25);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(58, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "description";
            // 
            // lblpodcast
            // 
            this.lblpodcast.AutoSize = true;
            this.lblpodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpodcast.Location = new System.Drawing.Point(6, 2);
            this.lblpodcast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpodcast.Name = "lblpodcast";
            this.lblpodcast.Size = new System.Drawing.Size(110, 16);
            this.lblpodcast.TabIndex = 6;
            this.lblpodcast.Text = "Podcast Name";
            // 
            // tbCntrPod
            // 
            this.tbCntrPod.Controls.Add(this.tbPodInfo);
            this.tbCntrPod.Controls.Add(this.tbEpisodeInfo);
            this.tbCntrPod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCntrPod.Location = new System.Drawing.Point(634, 12);
            this.tbCntrPod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbCntrPod.Name = "tbCntrPod";
            this.tbCntrPod.SelectedIndex = 0;
            this.tbCntrPod.Size = new System.Drawing.Size(460, 232);
            this.tbCntrPod.TabIndex = 17;
            // 
            // pnlEditPod
            // 
            this.pnlEditPod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditPod.Controls.Add(this.label3);
            this.pnlEditPod.Controls.Add(this.label2);
            this.pnlEditPod.Controls.Add(this.label1);
            this.pnlEditPod.Controls.Add(this.BtnDelete);
            this.pnlEditPod.Controls.Add(this.BtnCancel);
            this.pnlEditPod.Controls.Add(this.BtnSave);
            this.pnlEditPod.Controls.Add(this.cmbBoxNewInterval);
            this.pnlEditPod.Controls.Add(this.cmbBoxNewCategory);
            this.pnlEditPod.Controls.Add(this.txtBoxNewUrl);
            this.pnlEditPod.Location = new System.Drawing.Point(634, 12);
            this.pnlEditPod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlEditPod.Name = "pnlEditPod";
            this.pnlEditPod.Size = new System.Drawing.Size(460, 506);
            this.pnlEditPod.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Intervall(Min)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rss-Url:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Location = new System.Drawing.Point(188, 148);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(76, 24);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Radera";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Location = new System.Drawing.Point(299, 148);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(76, 24);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Avbryt";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Location = new System.Drawing.Point(86, 148);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(76, 24);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Spara";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmbBoxNewInterval
            // 
            this.cmbBoxNewInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxNewInterval.FormattingEnabled = true;
            this.cmbBoxNewInterval.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60"});
            this.cmbBoxNewInterval.Location = new System.Drawing.Point(299, 65);
            this.cmbBoxNewInterval.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbBoxNewInterval.Name = "cmbBoxNewInterval";
            this.cmbBoxNewInterval.Size = new System.Drawing.Size(120, 21);
            this.cmbBoxNewInterval.TabIndex = 2;
            // 
            // cmbBoxNewCategory
            // 
            this.cmbBoxNewCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxNewCategory.FormattingEnabled = true;
            this.cmbBoxNewCategory.Location = new System.Drawing.Point(86, 65);
            this.cmbBoxNewCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbBoxNewCategory.Name = "cmbBoxNewCategory";
            this.cmbBoxNewCategory.Size = new System.Drawing.Size(120, 21);
            this.cmbBoxNewCategory.TabIndex = 1;
            // 
            // txtBoxNewUrl
            // 
            this.txtBoxNewUrl.Location = new System.Drawing.Point(86, 22);
            this.txtBoxNewUrl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxNewUrl.Name = "txtBoxNewUrl";
            this.txtBoxNewUrl.Size = new System.Drawing.Size(334, 20);
            this.txtBoxNewUrl.TabIndex = 0;
            // 
            // cmbBoxCategoryDeleteOrEdit
            // 
            this.cmbBoxCategoryDeleteOrEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCategoryDeleteOrEdit.FormattingEnabled = true;
            this.cmbBoxCategoryDeleteOrEdit.Location = new System.Drawing.Point(32, 402);
            this.cmbBoxCategoryDeleteOrEdit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbBoxCategoryDeleteOrEdit.Name = "cmbBoxCategoryDeleteOrEdit";
            this.cmbBoxCategoryDeleteOrEdit.Size = new System.Drawing.Size(120, 21);
            this.cmbBoxCategoryDeleteOrEdit.TabIndex = 19;
            // 
            // BtnEditCategory
            // 
            this.BtnEditCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditCategory.Location = new System.Drawing.Point(160, 400);
            this.BtnEditCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnEditCategory.Name = "BtnEditCategory";
            this.BtnEditCategory.Size = new System.Drawing.Size(73, 24);
            this.BtnEditCategory.TabIndex = 20;
            this.BtnEditCategory.Text = "Ändra";
            this.BtnEditCategory.UseVisualStyleBackColor = true;
            this.BtnEditCategory.Click += new System.EventHandler(this.BtnEditCategory_Click);
            // 
            // pnlEditCategory
            // 
            this.pnlEditCategory.Controls.Add(this.BtnCancelCategory);
            this.pnlEditCategory.Controls.Add(this.BtnSaveCategory);
            this.pnlEditCategory.Controls.Add(this.txtBoxNewCategoryName);
            this.pnlEditCategory.Location = new System.Drawing.Point(32, 296);
            this.pnlEditCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlEditCategory.Name = "pnlEditCategory";
            this.pnlEditCategory.Size = new System.Drawing.Size(288, 212);
            this.pnlEditCategory.TabIndex = 21;
            this.pnlEditCategory.Visible = false;
            // 
            // BtnCancelCategory
            // 
            this.BtnCancelCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelCategory.Location = new System.Drawing.Point(140, 148);
            this.BtnCancelCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnCancelCategory.Name = "BtnCancelCategory";
            this.BtnCancelCategory.Size = new System.Drawing.Size(76, 24);
            this.BtnCancelCategory.TabIndex = 2;
            this.BtnCancelCategory.Text = "Avbryt";
            this.BtnCancelCategory.UseVisualStyleBackColor = true;
            this.BtnCancelCategory.Click += new System.EventHandler(this.BtnCancelCategory_Click);
            // 
            // BtnSaveCategory
            // 
            this.BtnSaveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveCategory.Location = new System.Drawing.Point(32, 149);
            this.BtnSaveCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnSaveCategory.Name = "BtnSaveCategory";
            this.BtnSaveCategory.Size = new System.Drawing.Size(76, 24);
            this.BtnSaveCategory.TabIndex = 1;
            this.BtnSaveCategory.Text = "Spara";
            this.BtnSaveCategory.UseVisualStyleBackColor = true;
            this.BtnSaveCategory.Click += new System.EventHandler(this.BtnSaveCategory_Click);
            // 
            // txtBoxNewCategoryName
            // 
            this.txtBoxNewCategoryName.Location = new System.Drawing.Point(88, 80);
            this.txtBoxNewCategoryName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxNewCategoryName.Name = "txtBoxNewCategoryName";
            this.txtBoxNewCategoryName.Size = new System.Drawing.Size(104, 20);
            this.txtBoxNewCategoryName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1100, 527);
            this.Controls.Add(this.pnlEditCategory);
            this.Controls.Add(this.BtnEditCategory);
            this.Controls.Add(this.cmbBoxCategoryDeleteOrEdit);
            this.Controls.Add(this.pnlEditPod);
            this.Controls.Add(this.tbCntrPod);
            this.Controls.Add(this.BtnFilterByCategory);
            this.Controls.Add(this.cmbBoxFilterByCategory);
            this.Controls.Add(this.BtnDeleteCategory);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Podcast Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbEpisodeInfo.ResumeLayout(false);
            this.tbEpisodeInfo.PerformLayout();
            this.tbPodInfo.ResumeLayout(false);
            this.tbPodInfo.PerformLayout();
            this.tbCntrPod.ResumeLayout(false);
            this.pnlEditPod.ResumeLayout(false);
            this.pnlEditPod.PerformLayout();
            this.pnlEditCategory.ResumeLayout(false);
            this.pnlEditCategory.PerformLayout();
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
        private System.Windows.Forms.Button BtnDeleteCategory;
        private System.Windows.Forms.ComboBox cmbBoxFilterByCategory;
        private System.Windows.Forms.Button BtnFilterByCategory;
        private System.Windows.Forms.TabPage tbEpisodeInfo;
        private System.Windows.Forms.Label lblEpisodeTitle;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.LinkLabel lnkLblDownloadEpisode;
        private System.Windows.Forms.TabPage tbPodInfo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblpodcast;
        private System.Windows.Forms.TabControl tbCntrPod;
        private System.Windows.Forms.Button BtnEditPod;
        private System.Windows.Forms.Panel pnlEditPod;
        private System.Windows.Forms.ComboBox cmbBoxNewCategory;
        private System.Windows.Forms.TextBox txtBoxNewUrl;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox cmbBoxNewInterval;
        private System.Windows.Forms.ComboBox cmbBoxCategoryDeleteOrEdit;
        private System.Windows.Forms.Button BtnEditCategory;
        private System.Windows.Forms.CheckBox checkBoxHasListenTo;
        private System.Windows.Forms.Panel pnlEditCategory;
        private System.Windows.Forms.Button BtnCancelCategory;
        private System.Windows.Forms.Button BtnSaveCategory;
        private System.Windows.Forms.TextBox txtBoxNewCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

