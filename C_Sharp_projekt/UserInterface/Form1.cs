using Logic;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;


namespace UserInterface
{
    public partial class Form1 : Form
    {
        private PodcastService podcastService = new PodcastService();
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            podcastService.LoadPodcasts();
            SetStartUpInterface();
        }

        private void SetStartUpInterface()
        {
            UpdateCategories();
            cmbBoxInterval.SelectedIndex = 0;
            tbCntrPod.Visible = false;
            BtnPlay.Visible = false;
            pnlEditPod.Visible = false;
        }

        private void UpdateCategories()
        {
            if (podcastService.GetCategories().Count == 0)
            {
                podcastService.AddDefaultCategory();
            }
            ClearCategoryComboBoxs();
            AddToCategoryComboBoxs();
        }

        private void AddToCategoryComboBoxs()
        {
            foreach (var item in podcastService.GetCategories())
            {
                cmbBoxCategories.Items.Add(item);
                cmbBoxNewCategory.Items.Add(item);
                cmbBoxFilterByCategory.Items.Add(item);
                cmbBoxCategoryDeleteOrEdit.Items.Add(item);
            }
            cmbBoxNewCategory.SelectedIndex = 0;
            cmbBoxCategories.SelectedIndex = 0;
            cmbBoxFilterByCategory.SelectedIndex = 0;
            cmbBoxCategoryDeleteOrEdit.SelectedIndex = 0;
        }

        private void ClearCategoryComboBoxs()
        {
            cmbBoxCategories.Items.Clear();
            cmbBoxNewCategory.Items.Clear();
            cmbBoxFilterByCategory.Items.Clear();
            cmbBoxCategoryDeleteOrEdit.Items.Clear();
        }

        private void UpdateTreeView()
        {
            var podNames = podcastService.GetAllPodNames();
            AddNodes(podNames);
        }
        private void UpdateTreeView(string[] pods)
        {
            AddNodes(pods);
        }

        private void AddNodes(string[] pods)
        {
            treeViewPodcasts.Nodes.Clear();
            for (int i = 0; i < pods.Length; i++)
            {
                treeViewPodcasts.Nodes.Add(pods[i]);
                AddChildNodes(pods[i], i);
            }
        }

        private void AddChildNodes(string p, int index)
        {
            String[] episodes = podcastService.GetPodTitels(p);
            for (int j = 0; j < episodes.Length; j++)
            {
                treeViewPodcasts.Nodes[index].Nodes.Add(episodes[j]);
            }
        }

        private void treeViewPodcasts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tbCntrPod.Visible = true;
            if (treeViewPodcasts.SelectedNode.Nodes.Count == 0)
            {
                EpisodeIsClicked();
            }
            else
            {
                PodcastIsClicked();
            }
            
        }

        private void EpisodeIsClicked()
        {
            lblEpisodeTitle.Visible = true;
            lnkLblDownloadEpisode.Visible = true;
            lblEpisodeTitle.Text = treeViewPodcasts.SelectedNode.Text;
            if (lblpodcast.Text != treeViewPodcasts.SelectedNode.Parent.Text)
            {
                lblpodcast.Text = treeViewPodcasts.SelectedNode.Parent.Text;
                AddPodcastDescription();
            }

            if (podcastService.EpisodeIsDownloaded(treeViewPodcasts.SelectedNode.Text, lblpodcast.Text))
            {
                BtnPlay.Visible = true;
            }
            else
            {
                BtnPlay.Visible = false;
            }
        }

        private void PodcastIsClicked()
        {
            lblEpisodeTitle.Visible = false;
            lnkLblDownloadEpisode.Visible = false;
            BtnPlay.Visible = false;
            lblpodcast.Text = treeViewPodcasts.SelectedNode.Text;
            AddPodcastDescription();
        }

        private void AddPodcastDescription()
        {
            string description = podcastService.GetDescription(lblpodcast.Text);
            description = AddNewLines(description);
            lblDescription.Text = description;
        }

        private string AddNewLines(string description)
        {
            int blanc_count = 0;
            char[] descriptionAsChar = description.ToCharArray();
            for (int i = 0; i < descriptionAsChar.Length; i++)
            {
                if(descriptionAsChar[i] == ' ')
                {
                    blanc_count++;
                    if(blanc_count % 5 == 0)
                    {
                        descriptionAsChar[i] = '\n';
                    }
                }
            }
            return description = new string(descriptionAsChar);
        }

        private int GetIntervalByIndex(string u)
        {
            for (int i = 0; i < cmbBoxNewInterval.Items.Count; i++)
            {
                string value = cmbBoxNewInterval.GetItemText(cmbBoxNewInterval.Items[i]);
                if (u.Equals(value))
                {
                    return i;
                }
            }
            return 0;
        }

        private int GetCategoryIndex(string c)
        {
            for (int i = 0; i < cmbBoxNewCategory.Items.Count; i++)
            {
                string value = cmbBoxNewCategory.GetItemText(cmbBoxNewCategory.Items[i]);
                if (c.Equals(value))
                {
                    return i;
                }
            }
            return 0;
        }

        /* All On-click methods below */

        private void lnkLblDownloadEpisode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            podcastService.DownloadEpisode(treeViewPodcasts.SelectedNode.Text, treeViewPodcasts.SelectedNode.Parent.Text);
        }

        private void BtnShowAllPods_Click(object sender, EventArgs e)
        {
            UpdateTreeView();
        }
        
        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string toDelete = cmbBoxCategoryDeleteOrEdit.Text;
                podcastService.DeleteCategory(toDelete);
                UpdateCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            podcastService.PlayEpisode(treeViewPodcasts.SelectedNode.Text, treeViewPodcasts.SelectedNode.Parent.Text);
        }

        private void BtnFilterByCategory_Click(object sender, EventArgs e)
        {
            string category = cmbBoxFilterByCategory.Text;
            UpdateTreeView(podcastService.FilterByCategory(category));
        }

        private void BtnEditPod_Click(object sender, EventArgs e)
        {
                pnlEditPod.Visible = true;
                txtBoxNewUrl.Text = podcastService.GetPodcastUrl(lblpodcast.Text);
                cmbBoxNewCategory.SelectedIndex = GetCategoryIndex(podcastService.GetPodCategory(lblpodcast.Text));
                cmbBoxNewInterval.SelectedIndex = GetIntervalByIndex(podcastService.GetPodInterval(lblpodcast.Text));
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            podcastService.DeletePodcast(lblpodcast.Text);
            UpdateTreeView();
            pnlEditPod.Visible = false;
            tbCntrPod.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            pnlEditPod.Visible = false;
        }

        private void BtnAddRss_Click(object sender, EventArgs e)
        {
            try
            {
                String rss_url = txtBoxUrl.Text;
                String rss_name = txtBoxRssName.Text;
                String interval = cmbBoxInterval.Text;
                String category = cmbBoxCategories.Text;

                podcastService.AddPodcast(rss_url, rss_name, interval, category);
                txtBoxRssName.Clear();
                txtBoxUrl.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string category = txtBoxNewCategory.Text;
                podcastService.AddCategory(category);
                UpdateCategories();
                txtBoxNewCategory.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string oldName = lblpodcast.Text;
                string newUrl = txtBoxNewUrl.Text;
                string newCategory = cmbBoxNewCategory.Text;
                string newInterval = cmbBoxNewInterval.Text;
                podcastService.SavePodcast(oldName, newUrl, newCategory, newInterval);
                pnlEditPod.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
