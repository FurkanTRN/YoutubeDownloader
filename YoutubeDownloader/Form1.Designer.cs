namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ThumbnailBox = new System.Windows.Forms.PictureBox();
            this.VideoTitle = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.VideoAuthor = new System.Windows.Forms.Label();
            this.VideoDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DownloadVideoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VideoUrl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ThumbnailBox
            // 
            this.ThumbnailBox.Location = new System.Drawing.Point(126, 95);
            this.ThumbnailBox.Name = "ThumbnailBox";
            this.ThumbnailBox.Size = new System.Drawing.Size(212, 123);
            this.ThumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThumbnailBox.TabIndex = 0;
            this.ThumbnailBox.TabStop = false;
            // 
            // VideoTitle
            // 
            this.VideoTitle.AutoSize = true;
            this.VideoTitle.Location = new System.Drawing.Point(129, 236);
            this.VideoTitle.Name = "VideoTitle";
            this.VideoTitle.Size = new System.Drawing.Size(154, 15);
            this.VideoTitle.TabIndex = 1;
            this.VideoTitle.Text = "Youtube Video Downloader ";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(70, 44);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(289, 23);
            this.SearchBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(365, 44);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(51, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // VideoAuthor
            // 
            this.VideoAuthor.AutoSize = true;
            this.VideoAuthor.Location = new System.Drawing.Point(129, 261);
            this.VideoAuthor.Name = "VideoAuthor";
            this.VideoAuthor.Size = new System.Drawing.Size(132, 15);
            this.VideoAuthor.TabIndex = 4;
            this.VideoAuthor.Text = "github.com/FurkanTRN";
            // 
            // VideoDuration
            // 
            this.VideoDuration.AutoSize = true;
            this.VideoDuration.Location = new System.Drawing.Point(129, 285);
            this.VideoDuration.Name = "VideoDuration";
            this.VideoDuration.Size = new System.Drawing.Size(174, 15);
            this.VideoDuration.TabIndex = 5;
            this.VideoDuration.Text = "Only 144p, 360p and 720p video";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Author :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Duration :";
            // 
            // DownloadVideoButton
            // 
            this.DownloadVideoButton.Location = new System.Drawing.Point(175, 375);
            this.DownloadVideoButton.Name = "DownloadVideoButton";
            this.DownloadVideoButton.Size = new System.Drawing.Size(146, 23);
            this.DownloadVideoButton.TabIndex = 9;
            this.DownloadVideoButton.Text = "Download Video";
            this.DownloadVideoButton.UseVisualStyleBackColor = true;
            this.DownloadVideoButton.Click += new System.EventHandler(this.DownloadVideoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Url :";
            // 
            // VideoUrl
            // 
            this.VideoUrl.AutoSize = true;
            this.VideoUrl.Location = new System.Drawing.Point(129, 309);
            this.VideoUrl.Name = "VideoUrl";
            this.VideoUrl.Size = new System.Drawing.Size(22, 15);
            this.VideoUrl.TabIndex = 12;
            this.VideoUrl.Text = "Url";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Location = new System.Drawing.Point(175, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(342, 479);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(146, 23);
            this.OpenFileButton.TabIndex = 16;
            this.OpenFileButton.Text = "Open Output Folder";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 514);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.VideoUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DownloadVideoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VideoDuration);
            this.Controls.Add(this.VideoAuthor);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.VideoTitle);
            this.Controls.Add(this.ThumbnailBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 553);
            this.MinimumSize = new System.Drawing.Size(516, 553);
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ThumbnailBox;
        private Label VideoTitle;
        private TextBox SearchBox;
        private Button SearchButton;
        private Label VideoAuthor;
        private Label VideoDuration;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button DownloadVideoButton;
        private Label label4;
        private Label VideoUrl;
        private ComboBox comboBox1;
        private Button OpenFileButton;
    }
}