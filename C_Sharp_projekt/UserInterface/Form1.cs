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

                podcastService.AddPodcast(rss_url, rss_name);
                txtBoxRssName.Clear();
                txtBoxUrl.Clear();
            }
            catch (Exception)
            {
                throw;
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
            
        }
    }
}
