using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;
using AngleSharp.Dom;
using System.Diagnostics;
using Microsoft.Toolkit.Uwp.Notifications;

namespace YoutubeDownloader

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            VideoTitle.Text = " Youtube Downloader with Windows Forms C#";
            VideoAuthor.Text = "github.com/FurkanTRN";
            DownloadVideoButton.Enabled = false;

        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(SearchBox.Text);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(SearchBox.Text);
                VideoTitle.Text = video.Title.ToString();
                VideoAuthor.Text = video.Author.ChannelTitle;
                VideoDuration.Text = video.Duration.ToString();
                VideoUrl.Text = video.Url.ToString();
                ThumbnailBox.ImageLocation = "https://img.youtube.com/vi/" + video.Id + "/hqdefault.jpg";
                DownloadVideoButton.Enabled = true;
                comboBox1.Items.Add("144p");
                comboBox1.Items.Add("360p");
                comboBox1.Items.Add("720p");

            }
            catch (Exception ex)
            {
                MessageBox.Show("URL not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void DownloadVideoButton_Click(object sender, EventArgs e)
        {
            SearchButton.Enabled = false;
            DownloadVideoButton.Enabled = false;
            var youtube = new YoutubeClient();
            DownloadVideo(youtube, SearchBox.Text);
        }

        private async void DownloadVideo(YoutubeClient youtube, string url)
        {
            try
            {
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                var video = await youtube.Videos.GetAsync(url);
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

                var audioStreamInfo = streamManifest.GetAudioStreams().GetWithHighestBitrate();
                var videoStreamInfo = streamManifest.GetVideoStreams().First(s => s.VideoQuality.Label ==comboBox1.SelectedItem.ToString());
                var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };
                String videoName = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\" + video.Id + ".mp4";

                await youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder(videoName).Build());
                new ToastContentBuilder().AddText("Download Finished!").Show();
                SearchButton.Enabled = true;
            }
            catch(Exception ex)
            {
                new ToastContentBuilder().AddText(ex.Message).Show();
                SearchButton.Enabled = true;
            }
           
           
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));

        }
    }
}