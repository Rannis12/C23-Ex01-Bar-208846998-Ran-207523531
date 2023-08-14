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
    public partial class GenerateRandomAlbumForm : Form
    {
        private readonly User r_LoggedInUser;
        public GenerateRandomAlbumForm(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        private void generateAlbumButton_Click(object sender, EventArgs e)
        {
            HashSet<Photo> photos = new HashSet<Photo>();
            Random photoRnd = new Random();

            if (!isUserHaveAtLeastFourPhotos())
            {
                //MessageBox.Show("Error!", MessageBoxButtons.OK,
                //                                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    int albumIndex = generateRandomAlbumIndex();
                    int photoIndex = photoRnd.Next(0, r_LoggedInUser.Albums[albumIndex].Photos.Count - 1);

                    while (!photos.Add(r_LoggedInUser.Albums[albumIndex].Photos[photoIndex]))
                    {
                        albumIndex = generateRandomAlbumIndex();
                        photoIndex = photoRnd.Next(0, r_LoggedInUser.Albums[albumIndex].Photos.Count - 1);
                    }
                }

                pictureBox1.LoadAsync(photos.ElementAt(0).PictureNormalURL);
                pictureBox2.LoadAsync(photos.ElementAt(1).PictureNormalURL);
                pictureBox3.LoadAsync(photos.ElementAt(2).PictureNormalURL);
                pictureBox4.LoadAsync(photos.ElementAt(3).PictureNormalURL);
            }
        }

        private bool isUserHaveAtLeastFourPhotos()
        {
            int count = 0;

            foreach (Album album in r_LoggedInUser.Albums)
            {
                count += album.Photos.Count;
            }

            return count >= 4;
        }

        private int generateRandomAlbumIndex()
        {
            Random albumRnd = new Random();
            int albumIndex = albumRnd.Next(0, r_LoggedInUser.Albums.Count - 1);

            while(r_LoggedInUser.Albums[albumIndex].Photos.Count == 0)
            {
                albumIndex = albumRnd.Next(0, r_LoggedInUser.Albums.Count - 1);
            }

            return albumIndex;
        }
    }
}
