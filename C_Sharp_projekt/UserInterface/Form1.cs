using Logic;
using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace UserInterface
{
    public partial class Form1 : Form
    {
        private PodcastService podcastService = new PodcastService();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddRss_Click(object sender, EventArgs e)
        {
            try
            {
                String rss_url = txtBoxUrl.Text;
                String rss_name = txtBoxRssName.Text;
                String interval = cmbBoxInterval.Text;
                String category = cmbBoxInterval.Text;

                podcastService.AddPodcast(rss_url, rss_name, interval, category);
                txtBoxRssName.Clear();
                txtBoxUrl.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnShowAllPods_Click(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            treeViewPodcasts.Nodes.Clear();
            var podNames = podcastService.GetAllPodNames();
            for (int i = 0; i < podNames.Length; i++)
            {
                treeViewPodcasts.Nodes.Add(podNames[i]);
                String[] episodes = podcastService.GetPodTitels(podNames[i]);
                for (int j = 0; j < episodes.Length; j++)
                {
                    treeViewPodcasts.Nodes[i].Nodes.Add(episodes[j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            podcastService.LoadPodcasts();
            UpdateCategories();
            cmbBoxInterval.SelectedIndex = 0;
            grpBoxPodPreview.Visible = false;
            BtnPlay.Visible = false;
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            string category = txtBoxNewCategory.Text;
            podcastService.AddCategory(category);
            UpdateCategories();
            txtBoxNewCategory.Clear();
        }

        private void UpdateCategories()
        {
            if (podcastService.GetCategories().Count == 0)
            {
                podcastService.AddDefaultCategory();
                cmbBoxCategories.SelectedIndex = 0;
                return;
            }
            cmbBoxCategories.Items.Clear();
            cmbBoxNewCategory.Items.Clear();
            foreach (var item in podcastService.GetCategories())
            {
                cmbBoxCategories.Items.Add(item);
                cmbBoxNewCategory.Items.Add(item);
            }
            cmbBoxCategories.SelectedIndex = 0;
        }

        private void treeViewPodcasts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            grpBoxPodPreview.Visible = true;
            if (treeViewPodcasts.SelectedNode.Nodes.Count == 0)
            {
                lblEpisodeTitle.Visible = true;
                lnkLblDownloadEpisode.Visible = true;
                grpBoxPodInfo.Visible = false;
                lblEpisodeTitle.Text = treeViewPodcasts.SelectedNode.Text;

                if (podcastService.EpisodeIsDownloaded(treeViewPodcasts.SelectedNode.Text, treeViewPodcasts.SelectedNode.Parent.Text))
                {
                    BtnPlay.Visible = true;
                }
                else
                {
                    BtnPlay.Visible = false;
                }
            }
            else
            {
                lblEpisodeTitle.Visible = false;
                lnkLblDownloadEpisode.Visible = false;
                SetUpPodInfo();
            }
            
        }

        private void SetUpPodInfo()
        {
            grpBoxPodInfo.Visible = true;
            BtnPlay.Visible = false;
            txtBoxNewPodName.Text = treeViewPodcasts.SelectedNode.Text;
            string c = podcastService.GetPodCategory(treeViewPodcasts.SelectedNode.Text);
            string u = podcastService.GetPodInterval(treeViewPodcasts.SelectedNode.Text);
            cmbBoxNewCategory.SelectedIndex = GetCategoryIndex(c);
            cmbBoxNewInterval.SelectedIndex = GetIntervalByIndex(u);
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

        private void lnkLblDownloadEpisode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            podcastService.DownloadEpisode(treeViewPodcasts.SelectedNode.Text, treeViewPodcasts.SelectedNode.Parent.Text);
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            string toDelete = cmbBoxCategories.Text;
            podcastService.DeleteCategory(toDelete);
            UpdateCategories();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            podcastService.PlayEpisode(treeViewPodcasts.SelectedNode.Text, treeViewPodcasts.SelectedNode.Parent.Text);
        }

        private void BtnSavePod_Click(object sender, EventArgs e)
        {
            string oldName = treeViewPodcasts.SelectedNode.Text;
            string newName = txtBoxNewPodName.Text;
            string newCategory = cmbBoxNewCategory.Text;
            string newInterval = cmbBoxNewInterval.Text;
            podcastService.SavePodcast(oldName, newName, newCategory, newInterval);
        }

        private void BtnDeletePod_Click(object sender, EventArgs e)
        {
            podcastService.DeletePodcast(treeViewPodcasts.SelectedNode.Text);
            UpdateTreeView();
        }
    }
}
