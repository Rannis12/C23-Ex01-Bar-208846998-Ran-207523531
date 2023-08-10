using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class AlbumsForm : Form
    {
        public AlbumsForm()
        {
            InitializeComponent();
        }

        public void FetchAllAlbums(FacebookObjectCollection<Album> i_Albums)
        {
            albumsPages.Items.Clear();

            foreach (Album album in i_Albums)
            {
                albumsPages.Items.Add(album);
            }

            if (albumsPages.Items.Count == 0)
            {
                albumsPages.Text = "No albums to show :(";
            }
        }


        private void albumsPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (albumsPages.SelectedItems.Count == 1)
            {
                Album selectedAlbum = albumsPages.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    albumsPictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    albumsPictureBox.Image = albumsPictureBox.ErrorImage;
                }
            }
        }
    }
}
