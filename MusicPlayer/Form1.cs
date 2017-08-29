using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WindowsMediaPlayer();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "MP3|*.mp3";
            ofd.InitialDirectory = @"D:\workspace\music";

            if (ofd.ShowDialog() == DialogResult.OK)
            {                
                string filePath = ofd.FileName;
                listBox.Items.Add(filePath);
                // string songName = Path.GetFileNameWithoutExtension(filePath);
                // songNameLabel.Text = songName; 
            }

        }

        private void listBox_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("asggasf");        
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            // MessageBox.Show((string)listBox.SelectedItem);

            string file = (string)listBox.SelectedItem;           
            player.URL = file;
            player.controls.play();
            string songName = Path.GetFileNameWithoutExtension(file);
            songNameLabel.Text = songName;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            string file = (string)listBox.SelectedItem;
            player.URL = file;
            player.controls.play();
            string songName = Path.GetFileNameWithoutExtension(file);
            songNameLabel.Text = songName;           
            // playBtn.Enabled = false;
            // pauseBtn.Enabled = true;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            // playBtn.Enabled = true;
            // pauseBtn.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //          
            // trackBar1.ValueChanged += new System.EventHandler(trackBar1_ValueChanged);
            // this.Controls.Add(this.trackBar1);  
           // trackBar1.Value = player.settings.volume;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            player.settings.volume = volTrackBar.Value;
        }

        private void preBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > 0)
            {
                listBox.SelectedIndex--;
            }                     
            string file = (string)listBox.SelectedItem;
            player.URL = file;
            player.controls.play();
                   
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < listBox.Items.Count - 1)
            {
                listBox.SelectedIndex++;
            }            
            string file = (string)listBox.SelectedItem;
            player.URL = file;
            player.controls.play();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            volTrackBar.Value = player.settings.volume;
            
        }
    }
}