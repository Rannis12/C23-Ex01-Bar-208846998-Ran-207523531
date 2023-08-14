using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.subForms;
using BasicFacebookFeatures.SubForms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private readonly LogicManager r_LogicManager;
        private Form m_SubForm;
        
        private FavoriteTeamsForm m_FavoriteTeamsForm;
        private GroupsForm m_GroupsForm;
        private LikedPagesForm m_LikedPagesForm;
        private PostForm m_PostForm;
        private AlbumsForm m_AlbumsForm;
        private TopThreePostsForm m_TopThreePostsForm;
        private StatisticsForm m_statisticsForm;
        private GenerateRandomAlbumForm m_GenerateRandomAlbumForm;

        public MainForm()
        {
            InitializeComponent();
            r_LogicManager = new LogicManager();
            enableAllButtons(false);
            if (r_LogicManager.AppSettings.RememberUser &&
                                        !string.IsNullOrEmpty(r_LogicManager.AppSettings.LastAccessToken))
            {
                r_LogicManager.ConnectFromXml();
                allocateAllForms();
                loadUserData();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            r_LogicManager.Login();

            if(r_LogicManager.LoggedInUser != null)
            {
                loadUserData();
                enableAllButtons(true);

                if (rememberMeChoiceBox.Checked)
                {
                    r_LogicManager.SaveUserAccessToken();
                }

                allocateAllForms();
            }
            else
            {
                MessageBox.Show(r_LogicManager.LoginResult.ErrorMessage, "Error while logging in!", MessageBoxButtons.OK,
                                                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void allocateAllForms()
        {
            m_LikedPagesForm = new LikedPagesForm();
            m_FavoriteTeamsForm = new FavoriteTeamsForm();
            m_GroupsForm = new GroupsForm();
            m_PostForm = new PostForm(this.r_LogicManager.LoggedInUser);
            m_AlbumsForm = new AlbumsForm();
            m_TopThreePostsForm = new TopThreePostsForm();
            m_statisticsForm = new StatisticsForm(this.r_LogicManager.LoggedInUser);
            m_GenerateRandomAlbumForm = new GenerateRandomAlbumForm(this.r_LogicManager.LoggedInUser);
        }

        private void loadUserData()
        {
            loginButton.Text = "Logged in";
            loginButton.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = r_LogicManager.LoggedInUser.PictureNormalURL;

            pictureBoxProfile.LoadAsync(r_LogicManager.LoggedInUser.PictureNormalURL);

            rememberMeChoiceBox.Visible = false;
            loginButton.Enabled = false;
            logoutButton.Enabled = true;

            usernameLabel.Text = $"{r_LogicManager.LoggedInUser.FirstName} {r_LogicManager.LoggedInUser.LastName}";
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            m_PostForm.FetchPosts();
            loadSubForm(m_PostForm);
        }

        private void likedPagesButton_Click(object sender, EventArgs e)
        {
            m_LikedPagesForm.FetchPages(r_LogicManager.LoggedInUser.LikedPages);
            loadSubForm(m_LikedPagesForm);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            r_LogicManager.Logout();
            FacebookService.LogoutWithUI();
            this.Visible = false;
            usernameLabel.Text = "";
            enableAllButtons(false);

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void albumsButton_Click(object sender, EventArgs e)
        {
            m_AlbumsForm.FetchAllAlbums(r_LogicManager.LoggedInUser.Albums);
            loadSubForm(m_AlbumsForm);
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            m_GroupsForm.FetchGroups(r_LogicManager.LoggedInUser.Groups);
            loadSubForm(m_GroupsForm);
        }

        private void favoriteTeamsButton_Click(object sender, EventArgs e)
        {
            m_FavoriteTeamsForm.FetchTeams(r_LogicManager.LoggedInUser.FavofriteTeams);
            loadSubForm(m_FavoriteTeamsForm);
        }

        private void loadSubForm(Form i_SubForm)
        {
            m_SubForm?.Hide();
            m_SubForm = i_SubForm;
            i_SubForm.TopLevel = false;
            i_SubForm.FormBorderStyle = FormBorderStyle.None;
            i_SubForm.Dock = DockStyle.Fill;
            compenentsPanel.Controls.Add(i_SubForm);
            i_SubForm.BringToFront();
            i_SubForm.Show();
        }

        private void enableAllButtons(bool i_ShouldEnableButton)
        {

            dialogPanel.Visible = i_ShouldEnableButton;

        }

        private void topThreePostsButton_Click(object sender, EventArgs e)
        {
            m_TopThreePostsForm.FetchTopThreePosts(r_LogicManager.LoggedInUser.Posts);
            loadSubForm(m_TopThreePostsForm);
        }

        private void statisicsButton_Click(object sender, EventArgs e)
        {
            loadSubForm(m_statisticsForm);
        }

        private void randomAlbumButton_Click(object sender, EventArgs e)
        {
            loadSubForm(m_GenerateRandomAlbumForm);
        }
    }
}
