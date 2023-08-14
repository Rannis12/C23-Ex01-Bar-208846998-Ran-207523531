using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace BasicFacebookFeatures
{
    public class LogicManager
    {
        public AppSettings AppSettings { get; private set; }
        public LoginResult LoginResult { get; private set; }
        public User LoggedInUser{ get; private set; }

        public LogicManager()
        {
            AppSettings = AppSettings.LoadFormFile();
        }

        /*private void login()
        {
            m_LoginResult = FacebookWrapper.FacebookService.Login(
                "1038633494169557",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "user_friends");

            m_LoggedInUser = m_LoginResult.LoggedInUser;

            initLoginLabels();

            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile"
                /// add any relevant permissions
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
        }

        private void initLoginLabels()
        {
            if (m_LoggedInUser.Hometown != null)
            {
                cityLabel.Text = m_LoggedInUser.Hometown.Name;
            }
            else
            {
                cityLabel.Text = "No city found";
            }

            if (m_LoggedInUser.Birthday != null)
            {
                birthdayLabel.Text = m_LoggedInUser.Birthday;
            }
            else
            {
                birthdayLabel.Text = "no birthdate found";
            }


            string check = m_LoggedInUser.RelationshipStatus.ToString();

            string check3 = m_LoggedInUser.Checkins.ToString();

        }

        private void fetchAllAlbums()
        {
            listBoxAlbums.ClearSelected();

            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                listBoxAlbums.Text = "No albums to show :(";
            }
        }


        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void fetchLikedPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

    

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No posts found :(");
            }
        }

        private void fetchEducation()
        {
            listBoxCheckins.ClearSelected();

            foreach (Checkin checkin in m_LoggedInUser.Checkins)
            {
                if (checkin.Place != null)
                {
                    if (checkin.Place.Name != null)
                    {
                        listBoxCheckins.Items.Add(checkin.Place.Name);
                    }
                }
            }

            if (listBoxCheckins.Items.Count == 0)
            {
                listBoxCheckins.Text = "no check-ins :(";
            }
        }

        private void fetchThePostWithTheMostCommentsFeature()
        {
            Post theMostCommentsPost = null;
            int postCount = 0;

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (postCount < post.Comments.Count)
                {
                    theMostCommentsPost = post;
                    postCount = post.Comments.Count;
                }
            }
        }

        private void fetchRandomPhotoFeature()
        {
            Photo randomPhoto = null;

            List<Photo> photos = new List<Photo>();

            foreach (Album album in m_LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo != null)
                    {
                        photos.Add(photo);
                    }
                }
            }

            Random randInd = new Random();

            randomPhoto = photos[randInd.Next(0, photos.Count - 1)];

            //expose random photo - todo
        }
        */
        public void Login()
        {
            LoginResult = FacebookWrapper.FacebookService.Login(
                "1038633494169557",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "user_friends");

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
                //AppSettings.LastAccessToken = LoginResult.AccessToken;
            }
        }

        public void SaveUserAccessToken()
        {
            AppSettings.SaveUserAccessToken(LoginResult.AccessToken);
        }

        public void ConnectFromXml()
        {
            LoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
            LoggedInUser = LoginResult.LoggedInUser;
        }

        public void Logout()
        {
            LoginResult = null;
            LoggedInUser = null;
            AppSettings = new AppSettings();

            if(File.Exists("appSettings.xml"))
            {
                File.Delete("appSettings.xml");
            }
        }
    }
}
