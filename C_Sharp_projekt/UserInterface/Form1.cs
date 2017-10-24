using Logic;
using System;
using System.Windows.Forms;


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
            podcastService.AddDefaultCategory();
            UpdateCategories();
            cmbBoxInterval.SelectedIndex = 0;
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
            cmbBoxCategories.Items.Clear();
            foreach (var item in podcastService.GetCategories())
            {
                cmbBoxCategories.Items.Add(item);
            }
            cmbBoxCategories.SelectedIndex = 0;
        }
    }
}
