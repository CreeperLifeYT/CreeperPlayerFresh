namespace CreeperPlayer
{
    partial class PlayerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.TitleBar_Title = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.Playlist_Box = new System.Windows.Forms.ListBox();
            this.SongOpener_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentTrackPosition_Label = new System.Windows.Forms.Label();
            this.TrackLength_Label = new System.Windows.Forms.Label();
            this.SongOpener = new System.Windows.Forms.OpenFileDialog();
            this.TrackTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Volume_Slider = new MB.Controls.ColorSlider();
            this.TrackCurrentPositionSlider = new MB.Controls.ColorSlider();
            this.SongTitleLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.OtherTrackInfoLabel = new System.Windows.Forms.Label();
            this.TabsElement = new System.Windows.Forms.TabControl();
            this.TrackInfoTab = new System.Windows.Forms.TabPage();
            this.AlbumArtPicture = new System.Windows.Forms.PictureBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DonateButton = new System.Windows.Forms.Button();
            this.GithubButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LiveYoutubeChannelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainYoutubeChannelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.PictureBox();
            this.PreviousButton = new System.Windows.Forms.PictureBox();
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.PauseButton = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.TabsElement.SuspendLayout();
            this.TrackInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArtPicture)).BeginInit();
            this.AboutTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Lime;
            this.TitleBar.Controls.Add(this.TitleBar_Title);
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(640, 31);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // TitleBar_Title
            // 
            this.TitleBar_Title.AutoSize = true;
            this.TitleBar_Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar_Title.Location = new System.Drawing.Point(12, 7);
            this.TitleBar_Title.Name = "TitleBar_Title";
            this.TitleBar_Title.Size = new System.Drawing.Size(83, 15);
            this.TitleBar_Title.TabIndex = 2;
            this.TitleBar_Title.Text = "Creeper Player";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Image = global::CreeperPlayer.Properties.Resources.light_minimize;
            this.MinimizeButton.Location = new System.Drawing.Point(549, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 29);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::CreeperPlayer.Properties.Resources.light_close;
            this.CloseButton.Location = new System.Drawing.Point(594, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 29);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // Playlist_Box
            // 
            this.Playlist_Box.FormattingEnabled = true;
            this.Playlist_Box.HorizontalScrollbar = true;
            this.Playlist_Box.Location = new System.Drawing.Point(463, 48);
            this.Playlist_Box.Name = "Playlist_Box";
            this.Playlist_Box.Size = new System.Drawing.Size(175, 329);
            this.Playlist_Box.TabIndex = 1;
            this.Playlist_Box.SelectedIndexChanged += new System.EventHandler(this.Playlist_Box_SelectedIndexChanged);
            this.Playlist_Box.DoubleClick += new System.EventHandler(this.PlayButton_Click);
            // 
            // SongOpener_Button
            // 
            this.SongOpener_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.SongOpener_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongOpener_Button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongOpener_Button.Location = new System.Drawing.Point(463, 378);
            this.SongOpener_Button.Name = "SongOpener_Button";
            this.SongOpener_Button.Size = new System.Drawing.Size(175, 23);
            this.SongOpener_Button.TabIndex = 2;
            this.SongOpener_Button.Text = "Open";
            this.SongOpener_Button.UseVisualStyleBackColor = false;
            this.SongOpener_Button.Click += new System.EventHandler(this.SongOpener_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Playlist:";
            // 
            // CurrentTrackPosition_Label
            // 
            this.CurrentTrackPosition_Label.AutoSize = true;
            this.CurrentTrackPosition_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTrackPosition_Label.Location = new System.Drawing.Point(1, 382);
            this.CurrentTrackPosition_Label.Name = "CurrentTrackPosition_Label";
            this.CurrentTrackPosition_Label.Size = new System.Drawing.Size(49, 15);
            this.CurrentTrackPosition_Label.TabIndex = 5;
            this.CurrentTrackPosition_Label.Text = "00:00:00";
            // 
            // TrackLength_Label
            // 
            this.TrackLength_Label.AutoSize = true;
            this.TrackLength_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackLength_Label.Location = new System.Drawing.Point(415, 382);
            this.TrackLength_Label.Name = "TrackLength_Label";
            this.TrackLength_Label.Size = new System.Drawing.Size(49, 15);
            this.TrackLength_Label.TabIndex = 6;
            this.TrackLength_Label.Text = "00:00:00";
            // 
            // SongOpener
            // 
            this.SongOpener.Filter = resources.GetString("SongOpener.Filter");
            this.SongOpener.Multiselect = true;
            this.SongOpener.FileOk += new System.ComponentModel.CancelEventHandler(this.SongOpener_FileOk);
            // 
            // TrackTimer
            // 
            this.TrackTimer.Interval = 10;
            this.TrackTimer.Tick += new System.EventHandler(this.TrackTimer_Tick);
            // 
            // Volume_Slider
            // 
            this.Volume_Slider.BackColor = System.Drawing.Color.Transparent;
            this.Volume_Slider.BarInnerColor = System.Drawing.Color.WhiteSmoke;
            this.Volume_Slider.BarOuterColor = System.Drawing.Color.WhiteSmoke;
            this.Volume_Slider.BarPenColor = System.Drawing.Color.WhiteSmoke;
            this.Volume_Slider.BorderRoundRectSize = new System.Drawing.Size(15, 15);
            this.Volume_Slider.ElapsedInnerColor = System.Drawing.Color.Lime;
            this.Volume_Slider.ElapsedOuterColor = System.Drawing.Color.Lime;
            this.Volume_Slider.LargeChange = ((uint)(5u));
            this.Volume_Slider.Location = new System.Drawing.Point(351, 354);
            this.Volume_Slider.Name = "Volume_Slider";
            this.Volume_Slider.Size = new System.Drawing.Size(106, 20);
            this.Volume_Slider.SmallChange = ((uint)(1u));
            this.Volume_Slider.TabIndex = 15;
            this.Volume_Slider.ThumbInnerColor = System.Drawing.Color.Lime;
            this.Volume_Slider.ThumbOuterColor = System.Drawing.Color.Lime;
            this.Volume_Slider.ThumbPenColor = System.Drawing.Color.Lime;
            this.Volume_Slider.ThumbRoundRectSize = new System.Drawing.Size(15, 15);
            this.Volume_Slider.ThumbSize = 17;
            this.Volume_Slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Volume_Slider_Scroll);
            // 
            // TrackCurrentPositionSlider
            // 
            this.TrackCurrentPositionSlider.BackColor = System.Drawing.Color.Transparent;
            this.TrackCurrentPositionSlider.BarInnerColor = System.Drawing.Color.WhiteSmoke;
            this.TrackCurrentPositionSlider.BarOuterColor = System.Drawing.Color.WhiteSmoke;
            this.TrackCurrentPositionSlider.BarPenColor = System.Drawing.Color.WhiteSmoke;
            this.TrackCurrentPositionSlider.BorderRoundRectSize = new System.Drawing.Size(15, 15);
            this.TrackCurrentPositionSlider.ElapsedInnerColor = System.Drawing.Color.Lime;
            this.TrackCurrentPositionSlider.ElapsedOuterColor = System.Drawing.Color.Lime;
            this.TrackCurrentPositionSlider.LargeChange = ((uint)(5u));
            this.TrackCurrentPositionSlider.Location = new System.Drawing.Point(50, 380);
            this.TrackCurrentPositionSlider.Name = "TrackCurrentPositionSlider";
            this.TrackCurrentPositionSlider.Size = new System.Drawing.Size(362, 19);
            this.TrackCurrentPositionSlider.SmallChange = ((uint)(1u));
            this.TrackCurrentPositionSlider.TabIndex = 14;
            this.TrackCurrentPositionSlider.ThumbInnerColor = System.Drawing.Color.Lime;
            this.TrackCurrentPositionSlider.ThumbOuterColor = System.Drawing.Color.Lime;
            this.TrackCurrentPositionSlider.ThumbPenColor = System.Drawing.Color.Lime;
            this.TrackCurrentPositionSlider.ThumbRoundRectSize = new System.Drawing.Size(15, 15);
            this.TrackCurrentPositionSlider.ThumbSize = 17;
            this.TrackCurrentPositionSlider.Value = 0;
            this.TrackCurrentPositionSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackCurrentPositionSlider_Scroll);
            // 
            // SongTitleLabel
            // 
            this.SongTitleLabel.AutoSize = true;
            this.SongTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongTitleLabel.Location = new System.Drawing.Point(180, 33);
            this.SongTitleLabel.Name = "SongTitleLabel";
            this.SongTitleLabel.Size = new System.Drawing.Size(227, 37);
            this.SongTitleLabel.TabIndex = 17;
            this.SongTitleLabel.Text = "No song playing";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistLabel.Location = new System.Drawing.Point(182, 67);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(209, 25);
            this.ArtistLabel.TabIndex = 18;
            this.ArtistLabel.Text = "Press \"Open\" button to";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumLabel.Location = new System.Drawing.Point(183, 95);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(112, 20);
            this.AlbumLabel.TabIndex = 19;
            this.AlbumLabel.Text = "play your music";
            // 
            // OtherTrackInfoLabel
            // 
            this.OtherTrackInfoLabel.AutoSize = true;
            this.OtherTrackInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherTrackInfoLabel.Location = new System.Drawing.Point(184, 117);
            this.OtherTrackInfoLabel.Name = "OtherTrackInfoLabel";
            this.OtherTrackInfoLabel.Size = new System.Drawing.Size(57, 15);
            this.OtherTrackInfoLabel.TabIndex = 20;
            this.OtherTrackInfoLabel.Text = "Just do it!";
            // 
            // TabsElement
            // 
            this.TabsElement.Controls.Add(this.TrackInfoTab);
            this.TabsElement.Controls.Add(this.AboutTab);
            this.TabsElement.Location = new System.Drawing.Point(4, 37);
            this.TabsElement.Name = "TabsElement";
            this.TabsElement.SelectedIndex = 0;
            this.TabsElement.Size = new System.Drawing.Size(453, 304);
            this.TabsElement.TabIndex = 21;
            // 
            // TrackInfoTab
            // 
            this.TrackInfoTab.Controls.Add(this.SongTitleLabel);
            this.TrackInfoTab.Controls.Add(this.AlbumArtPicture);
            this.TrackInfoTab.Controls.Add(this.OtherTrackInfoLabel);
            this.TrackInfoTab.Controls.Add(this.ArtistLabel);
            this.TrackInfoTab.Controls.Add(this.AlbumLabel);
            this.TrackInfoTab.Location = new System.Drawing.Point(4, 22);
            this.TrackInfoTab.Name = "TrackInfoTab";
            this.TrackInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.TrackInfoTab.Size = new System.Drawing.Size(445, 278);
            this.TrackInfoTab.TabIndex = 0;
            this.TrackInfoTab.Text = "Track Information";
            this.TrackInfoTab.UseVisualStyleBackColor = true;
            // 
            // AlbumArtPicture
            // 
            this.AlbumArtPicture.Image = global::CreeperPlayer.Properties.Resources.no_album_art;
            this.AlbumArtPicture.Location = new System.Drawing.Point(22, 25);
            this.AlbumArtPicture.Name = "AlbumArtPicture";
            this.AlbumArtPicture.Size = new System.Drawing.Size(128, 128);
            this.AlbumArtPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumArtPicture.TabIndex = 16;
            this.AlbumArtPicture.TabStop = false;
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.groupBox1);
            this.AboutTab.Controls.Add(this.label7);
            this.AboutTab.Controls.Add(this.label6);
            this.AboutTab.Controls.Add(this.label5);
            this.AboutTab.Controls.Add(this.label3);
            this.AboutTab.Controls.Add(this.label4);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(445, 278);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.DonateButton);
            this.groupBox1.Controls.Add(this.GithubButton);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.LiveYoutubeChannelButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.MainYoutubeChannelButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developer links";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CreeperPlayer.Properties.Resources.DonationIcon;
            this.pictureBox4.Location = new System.Drawing.Point(228, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CreeperPlayer.Properties.Resources.GithubIcon;
            this.pictureBox3.Location = new System.Drawing.Point(17, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // DonateButton
            // 
            this.DonateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonateButton.Location = new System.Drawing.Point(219, 97);
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(207, 65);
            this.DonateButton.TabIndex = 8;
            this.DonateButton.Text = "                  Donate";
            this.DonateButton.UseVisualStyleBackColor = true;
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // GithubButton
            // 
            this.GithubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GithubButton.Location = new System.Drawing.Point(6, 97);
            this.GithubButton.Name = "GithubButton";
            this.GithubButton.Size = new System.Drawing.Size(207, 65);
            this.GithubButton.TabIndex = 7;
            this.GithubButton.Text = "                GitHub";
            this.GithubButton.UseVisualStyleBackColor = true;
            this.GithubButton.Click += new System.EventHandler(this.GithubButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CreeperPlayer.Properties.Resources.YoutubeIcon;
            this.pictureBox2.Location = new System.Drawing.Point(228, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // LiveYoutubeChannelButton
            // 
            this.LiveYoutubeChannelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LiveYoutubeChannelButton.Location = new System.Drawing.Point(219, 22);
            this.LiveYoutubeChannelButton.Name = "LiveYoutubeChannelButton";
            this.LiveYoutubeChannelButton.Size = new System.Drawing.Size(207, 65);
            this.LiveYoutubeChannelButton.TabIndex = 6;
            this.LiveYoutubeChannelButton.Text = "Live YouTube channel    ";
            this.LiveYoutubeChannelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LiveYoutubeChannelButton.UseVisualStyleBackColor = true;
            this.LiveYoutubeChannelButton.Click += new System.EventHandler(this.LiveYoutubeChannelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreeperPlayer.Properties.Resources.YoutubeIcon;
            this.pictureBox1.Location = new System.Drawing.Point(17, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainYoutubeChannelButton
            // 
            this.MainYoutubeChannelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainYoutubeChannelButton.Location = new System.Drawing.Point(6, 22);
            this.MainYoutubeChannelButton.Name = "MainYoutubeChannelButton";
            this.MainYoutubeChannelButton.Size = new System.Drawing.Size(207, 65);
            this.MainYoutubeChannelButton.TabIndex = 1;
            this.MainYoutubeChannelButton.Text = "Main YouTube channel   ";
            this.MainYoutubeChannelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainYoutubeChannelButton.UseVisualStyleBackColor = true;
            this.MainYoutubeChannelButton.Click += new System.EventHandler(this.MainYoutubeChannelButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Developer: CreeperLifeYT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(231, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(173, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(120, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Creeper Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(323, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fresh";
            // 
            // NextButton
            // 
            this.NextButton.Image = global::CreeperPlayer.Properties.Resources.next;
            this.NextButton.Location = new System.Drawing.Point(183, 347);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(32, 32);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextButton.TabIndex = 13;
            this.NextButton.TabStop = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseEnter += new System.EventHandler(this.NextButton_MouseEnter);
            this.NextButton.MouseLeave += new System.EventHandler(this.NextButton_MouseLeave);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = global::CreeperPlayer.Properties.Resources.previous;
            this.PreviousButton.Location = new System.Drawing.Point(145, 347);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(32, 32);
            this.PreviousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviousButton.TabIndex = 12;
            this.PreviousButton.TabStop = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            this.PreviousButton.MouseEnter += new System.EventHandler(this.PreviousButton_MouseEnter);
            this.PreviousButton.MouseLeave += new System.EventHandler(this.PreviousButton_MouseLeave);
            // 
            // StopButton
            // 
            this.StopButton.Image = global::CreeperPlayer.Properties.Resources.stop;
            this.StopButton.Location = new System.Drawing.Point(80, 347);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(32, 32);
            this.StopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopButton.TabIndex = 11;
            this.StopButton.TabStop = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            this.StopButton.MouseEnter += new System.EventHandler(this.StopButton_MouseEnter);
            this.StopButton.MouseLeave += new System.EventHandler(this.StopButton_MouseLeave);
            // 
            // PauseButton
            // 
            this.PauseButton.Image = global::CreeperPlayer.Properties.Resources.pause;
            this.PauseButton.Location = new System.Drawing.Point(42, 347);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(32, 32);
            this.PauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PauseButton.TabIndex = 10;
            this.PauseButton.TabStop = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            this.PauseButton.MouseEnter += new System.EventHandler(this.PauseButton_MouseEnter);
            this.PauseButton.MouseLeave += new System.EventHandler(this.PauseButton_MouseLeave);
            // 
            // PlayButton
            // 
            this.PlayButton.Image = global::CreeperPlayer.Properties.Resources.play;
            this.PlayButton.Location = new System.Drawing.Point(4, 347);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(32, 32);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayButton.TabIndex = 9;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            this.PlayButton.MouseEnter += new System.EventHandler(this.PlayButton_MouseEnter);
            this.PlayButton.MouseLeave += new System.EventHandler(this.PlayButton_MouseLeave);
            // 
            // PlayerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 403);
            this.Controls.Add(this.TabsElement);
            this.Controls.Add(this.Playlist_Box);
            this.Controls.Add(this.Volume_Slider);
            this.Controls.Add(this.TrackCurrentPositionSlider);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.CurrentTrackPosition_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SongOpener_Button);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.TrackLength_Label);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PlayerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creeper Player";
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayerForm_Paint);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.TabsElement.ResumeLayout(false);
            this.TrackInfoTab.ResumeLayout(false);
            this.TrackInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArtPicture)).EndInit();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label TitleBar_Title;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.ListBox Playlist_Box;
        private System.Windows.Forms.Button SongOpener_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentTrackPosition_Label;
        private System.Windows.Forms.Label TrackLength_Label;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.PictureBox PauseButton;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.Timer TrackTimer;
        public System.Windows.Forms.OpenFileDialog SongOpener;
        private System.Windows.Forms.PictureBox PreviousButton;
        private System.Windows.Forms.PictureBox NextButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private MB.Controls.ColorSlider TrackCurrentPositionSlider;
        private MB.Controls.ColorSlider Volume_Slider;
        private System.Windows.Forms.PictureBox AlbumArtPicture;
        private System.Windows.Forms.Label SongTitleLabel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label OtherTrackInfoLabel;
        private System.Windows.Forms.TabControl TabsElement;
        private System.Windows.Forms.TabPage TrackInfoTab;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MainYoutubeChannelButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LiveYoutubeChannelButton;
        private System.Windows.Forms.Button GithubButton;
        private System.Windows.Forms.Button DonateButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

