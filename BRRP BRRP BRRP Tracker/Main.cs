using NAudio;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace BRRP_BRRP_BRRP_Tracker
{
    public partial class Main : Form
    {
        int Brrps = 0;
        bool lColors = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {
            Brrp();
        }

        public void Brrp()
        {

            IncrementBrrp();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Play();
        }

        void IncrementBrrp(int amount = 1)
        {
            Brrps = Brrps + amount;
            if (Brrps > 6) NewColor();
            Checks();
            BrrpTracker.Text = "BRRP Tracker: " + Brrps.ToString();
        }

        public void NewColor()
        {
            // Generate a random RGB
            Random random = new Random();
            int rgbR = random.Next(20, 256);
            int rgbG = random.Next(20, 256);
            int rgbB = random.Next(20, 256);
            Color randColor = Color.FromArgb((rgbR - 20), (rgbG - 20), (rgbB - 20));

            // Set the colors
            this.BackColor = randColor;
            PlayButton.ForeColor = randColor;

            if (!lColors)
            {
                LabelColors();
                lColors = true;
            }
        }

        public void Checks()
        {
            // Statuses
            string status = "Status: ";
            if (Brrps > 6 && Brrps < 30) Status.Text = status + "step it up";
            if (Brrps > 29 && Brrps < 72) Status.Text = status + "slow it down man";
            if (Brrps > 71 && Brrps < 110) Status.Text = status + "bring it back a bit";
            if (Brrps > 109) Status.Text = status + "BRRP BRRP BRRP E";
        }

        void LabelColors()
        {
            System.Threading.ThreadPool.QueueUserWorkItem(delegate
            {
                while (true)
                {
                    // Generate a random RGB
                    Random random = new Random();
                    int rgbR = random.Next(20, 256);
                    int rgbG = random.Next(20, 256);
                    int rgbB = random.Next(20, 256);
                    Color randColorL = Color.FromArgb(rgbR, rgbG, rgbB);

                    Status.ForeColor = randColorL;
                    BrrpTracker.ForeColor = randColorL;
                    System.Threading.Thread.Sleep(50);
                }
            }, null);
        }

        void Play(string path = null)
        {
            if (!(path == null))
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
                player.Play();
            }
               else
            {
                OpenFileDialog SongBrowser = new OpenFileDialog();
                SongBrowser.Filter = "Music Files|*.wav;*.mp3|All Files (*.*)|*.*";
                SongBrowser.FilterIndex = 1;
                SongBrowser.Multiselect = false;
                if (SongBrowser.ShowDialog() == DialogResult.OK)
                {
                    System.Media.SoundPlayer player;
                    string type = Path.GetExtension(SongBrowser.FileName);
                    switch(type)
                    {
                        case ".wav":
                            player = new System.Media.SoundPlayer(SongBrowser.FileName);
                            player.Play();
                            break;
                        case ".mp3":
                            Title("Converting...");
                            using (Mp3FileReader mp3reader = new Mp3FileReader(SongBrowser.FileName))
                            {
                                string wavpath = Path.GetTempPath() + Path.GetFileName(SongBrowser.FileName) + ".mp3";
                                WaveFileWriter.CreateWaveFile(wavpath, mp3reader);
                                player = new System.Media.SoundPlayer(wavpath);
                                Title("reset");
                                player.Play();
                            }
                            break;
                        default:
                            MessageBox.Show("The system encountered an error while determining the conversion type.", "File Type Error");
                            break;
                    }
                }
            }
        }

        void Title(string title)
        {
            if (title.ToLower() == "reset")
            {
                this.Text = "BRRP BRRP BRRP Tracker";
                return;
            }
            this.Text = "BRRP BRRP BRRP Tracker - " + title;
        }

        private void an0nymooosebutton_Clicked(object sender, EventArgs e)
        {
            this.Icon = BRRP_BRRP_BRRP_Tracker.Properties.Resources.an0nymooose;
            an0nymooosebutton.Enabled = false;
        }
    }
}
