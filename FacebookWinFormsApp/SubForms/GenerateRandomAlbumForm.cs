using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;
using FacebookLogic.Handlers;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class GenerateRandomAlbumForm : Form
    {
        private readonly AlbumGenerationHandler r_AlbumGenerationHandler;
        public GenerateRandomAlbumForm(User i_LoggedInUser)
        {
            r_AlbumGenerationHandler = new AlbumGenerationHandler(i_LoggedInUser);
            InitializeComponent();
        }

        private void generateAlbumButton_Click(object sender, EventArgs e)
        {
            if (!r_AlbumGenerationHandler.IsUserHaveAtLeastFourPhotos())
            {
                MessageBox.Show("Error!", "You don't have at least four photos in your whole albums.", MessageBoxButtons.OK,
                                                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                HashSet<Photo> photos = r_AlbumGenerationHandler.GenerateAlbum();

                pictureBox1.LoadAsync(photos.ElementAt(0).PictureNormalURL);
                pictureBox2.LoadAsync(photos.ElementAt(1).PictureNormalURL);
                pictureBox3.LoadAsync(photos.ElementAt(2).PictureNormalURL);
                pictureBox4.LoadAsync(photos.ElementAt(3).PictureNormalURL);
            }
        }
    }
}
