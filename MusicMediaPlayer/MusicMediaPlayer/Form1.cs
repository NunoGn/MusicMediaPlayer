using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMediaPlayer
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //CODE TO SELECT SONGS
            OpenFileDialog ofd = new OpenFileDialog();
            //SELECT MULTIPLE FILES
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //SAVE THE NAMES OF THE TRACK IN FILES ARRAY
                paths = ofd.FileNames; //SAVE THE PATHS OF THE TRACKS IN PATH ARRAY
                //DISPLAY THE MUSIC TITLES IN LISTBOX
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //DISPLAY SONGS IN LISTBOX
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CODE TO PLAY MUSIC
            WindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
