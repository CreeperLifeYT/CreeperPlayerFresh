using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CreeperPlayer
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
            BassClass.InitBass(BassClass.Hertz);
            #region OpenFileDialog filter
            SongOpener.Filter = "MPEG Audio Layer 3|*.mp3"
                + "|Advanced Audio Coding|*.aac;*.m4a;*.mp4;*.3gp"
                + "|OGG Vorbis Audio|*.ogg"
                + "|OPUS Audio|*.opus"
                + "|Dolby Digital AC3|*.ac3"
                + "|Monkey's Audio|*.ape"
                + "|MusePack|*.mpc"
                + "|Free Lossless Audio Codec|*.flac"
                + "|Windows Media Audio|*.wma"
                + "|True Audio|*.tta"
                + "|Apple Lossless Audio Codec|*.alac"
                + "|MusePack|*.vw"
                //+ "|Musical Instrument Digital Interface|*.mid;*.midi";
            #endregion
        }

        #region Custom window

        private void PlayerForm_Paint(object sender, PaintEventArgs e)
        {
            Color LimeGreen = Color.FromArgb(24, 251, 24);
            Pen frame = new Pen(LimeGreen, 1);
            e.Graphics.DrawRectangle(frame, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr one, int two, int three, int four);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Application.Exit(); }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized; }

        #endregion

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            BassClass.SetVolumeToStream(BassClass.Stream, Volume_Slider.Value);
        }

        private void SongOpener_Button_Click(object sender, EventArgs e) {
            SongOpener.ShowDialog(); }

        private void SongOpener_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] tmp = SongOpener.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                Vars.Files.Add(tmp[i]);
                TrackTags trackTags = new TrackTags(tmp[i]);
                

                if (trackTags.Artist == string.Empty)
                {
                    Playlist_Box.Items.Add(trackTags.Title);
                }
                else
                {
                    Playlist_Box.Items.Add(trackTags.Artist + " - " + trackTags.Title);
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if ((Playlist_Box.Items.Count != 0) && (Playlist_Box.SelectedIndex != -1))
            {
                string current = Vars.Files[Playlist_Box.SelectedIndex];
                Vars.CurrentTrackNumber = Playlist_Box.SelectedIndex;
                
                BassClass.Play(current, BassClass.Volume);
                var currentPos = BassClass.GetPosOfStream(BassClass.Stream);
                var streamTime = BassClass.GetTimeOfStream(BassClass.Stream);
                CurrentTrackPosition_Label.Text = TimeSpan.FromSeconds(currentPos).ToString();
                TrackLength_Label.Text = TimeSpan.FromSeconds(streamTime).ToString();
                TrackCurrentPositionSlider.Maximum = streamTime;
                TrackCurrentPositionSlider.Value = currentPos;
                TrackTimer.Enabled = true;

                ProgressBarOnTaskbar.SetState(Handle, ProgressBarOnTaskbar.TaskbarStates.Normal);
                ProgressBarOnTaskbar.SetValue(Handle, currentPos, streamTime);
            }
        }

        private void Playlist_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current = Vars.Files[Playlist_Box.SelectedIndex];
            Vars.CurrentTrackNumber = Playlist_Box.SelectedIndex;

            TrackTags trackTags = new TrackTags(current);
            SongTitleLabel.Text = trackTags.Title;

            OtherTrackInfoLabel.Text = trackTags.BitRate.ToString() + "Kbps, " + trackTags.Channels +
                ", " + trackTags.Year;

            if (trackTags.Artist == string.Empty)
                ArtistLabel.Text = "Unknown artist";
            else
                ArtistLabel.Text = trackTags.Artist;

            if (trackTags.Artist == string.Empty)
            {
                AlbumArtPicture.Image = Properties.Resources.no_album_art;
            }
            else
            {
                // TODO: Make album arts
                AlbumLabel.Text = string.Empty;
            }

            if (trackTags.Year == string.Empty)
                OtherTrackInfoLabel.Text = trackTags.BitRate.ToString() + "Kbps, " + trackTags.Channels;
            else
                OtherTrackInfoLabel.Text = trackTags.BitRate.ToString() + "Kbps, " + trackTags.Channels +
                ", " + trackTags.Year;

        }

        private void TrackTimer_Tick(object sender, EventArgs e)
        {
            var currentPos = BassClass.GetPosOfStream(BassClass.Stream);
            var streamTime = BassClass.GetTimeOfStream(BassClass.Stream);
            CurrentTrackPosition_Label.Text = TimeSpan.FromSeconds(currentPos).ToString();
            TrackCurrentPositionSlider.Value = currentPos;
            ProgressBarOnTaskbar.SetValue(Handle, currentPos, streamTime);

            if (BassClass.ToNextTrack())
            {
                Playlist_Box.SelectedIndex = Vars.CurrentTrackNumber;
                CurrentTrackPosition_Label.Text = TimeSpan.FromSeconds(currentPos).ToString();
                TrackLength_Label.Text = TimeSpan.FromSeconds(streamTime).ToString();
                TrackCurrentPositionSlider.Maximum = streamTime;
                TrackCurrentPositionSlider.Value = currentPos;
            }
            if (BassClass.EndPlaylist)
            {
                StopButton_Click(this, new EventArgs());
                Playlist_Box.SelectedIndex = Vars.CurrentTrackNumber = 0;
                BassClass.EndPlaylist = false;
            }

            if (WindowState == FormWindowState.Minimized)
            {
                Text = Playlist_Box.SelectedItem.ToString();
            }
            else
                Text = "Creeper Player";
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            BassClass.Pause(); TrackTimer.Stop();
            var currentPos = BassClass.GetPosOfStream(BassClass.Stream);
            var streamTime = BassClass.GetTimeOfStream(BassClass.Stream);
            ProgressBarOnTaskbar.SetState(Handle, ProgressBarOnTaskbar.TaskbarStates.Paused);
            ProgressBarOnTaskbar.SetValue(Handle, currentPos, streamTime);
        }

        private void TrackCurrentPositionSlider_Scroll(object sender, ScrollEventArgs e) {
            BassClass.GetPosOfScroll(BassClass.Stream, TrackCurrentPositionSlider.Value); }

        private void Volume_Slider_Scroll(object sender, ScrollEventArgs e) {
            BassClass.SetVolumeToStream(BassClass.Stream, Volume_Slider.Value); }

        private void StopButton_Click(object sender, EventArgs e)
        {
            BassClass.Stop();
            TrackTimer.Enabled = false;
            TrackCurrentPositionSlider.Value = 0;
            CurrentTrackPosition_Label.Text = "00:00:00";
            ProgressBarOnTaskbar.SetState(Handle, ProgressBarOnTaskbar.TaskbarStates.Error);
            ProgressBarOnTaskbar.SetValue(Handle, 1, 1);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (Vars.Files.Count > Vars.CurrentTrackNumber - 1)
            {
                BassClass.Play(Vars.Files[--Vars.CurrentTrackNumber], BassClass.Volume);
                Playlist_Box.SelectedIndex = Vars.CurrentTrackNumber;
                BassClass.EndPlaylist = false;
            }
            else
                BassClass.EndPlaylist = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Vars.Files.Count > Vars.CurrentTrackNumber + 1)
            {
                BassClass.Play(Vars.Files[++Vars.CurrentTrackNumber], BassClass.Volume);
                Playlist_Box.SelectedIndex = Vars.CurrentTrackNumber;
                BassClass.EndPlaylist = false;
            }
            else
                BassClass.EndPlaylist = true;
        }

        #region Non-static buttons

        private void PlayButton_MouseEnter(object sender, EventArgs e) {
            PlayButton.Image = Properties.Resources.play_enter; }

        private void PlayButton_MouseLeave(object sender, EventArgs e) {
            PlayButton.Image = Properties.Resources.play; }

        private void PauseButton_MouseEnter(object sender, EventArgs e) {
            PauseButton.Image = Properties.Resources.pause_enter; }

        private void PauseButton_MouseLeave(object sender, EventArgs e) {
            PauseButton.Image = Properties.Resources.pause; }

        private void StopButton_MouseEnter(object sender, EventArgs e) {
            StopButton.Image = Properties.Resources.stop_enter; }

        private void StopButton_MouseLeave(object sender, EventArgs e) {
            StopButton.Image = Properties.Resources.stop; }

        private void PreviousButton_MouseEnter(object sender, EventArgs e) {
            PreviousButton.Image = Properties.Resources.previous_enter; }

        private void PreviousButton_MouseLeave(object sender, EventArgs e) {
            PreviousButton.Image = Properties.Resources.previous; }

        private void NextButton_MouseEnter(object sender, EventArgs e) {
            NextButton.Image = Properties.Resources.next_enter; }

        private void NextButton_MouseLeave(object sender, EventArgs e) {
            NextButton.Image = Properties.Resources.next; }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e) {
            MinimizeButton.Image = Properties.Resources.light_minimize_enter; }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e) {
            MinimizeButton.Image = Properties.Resources.light_minimize; }

        private void CloseButton_MouseEnter(object sender, EventArgs e) {
            CloseButton.Image = Properties.Resources.close_enter; }

        private void CloseButton_MouseLeave(object sender, EventArgs e) {
            CloseButton.Image = Properties.Resources.light_close; }


        #endregion

        public static void OpenApp(string app, string args)
        {
            ProcessStartInfo process = new ProcessStartInfo
            {
                FileName = app,
                Arguments = args
            };
            Process.Start(process);
        }

        private void MainYoutubeChannelButton_Click(object sender, EventArgs e)
        {
            OpenApp("explorer", "https://www.youtube.com/@CreeperLifeYT");
        }

        private void LiveYoutubeChannelButton_Click(object sender, EventArgs e)
        {
            OpenApp("explorer", "https://www.youtube.com/@dmitriy_creeperov");
        }

        private void GithubButton_Click(object sender, EventArgs e)
        {
            OpenApp("explorer", "https://github.com/CreeperLifeYT");
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            OpenApp("explorer", "https://new.donatepay.ru/@CreeperLifeYT");
        }
    }
}
