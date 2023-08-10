﻿using System;
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

        public MainForm()
        {
            r_LogicManager = new LogicManager();
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            r_LogicManager.LoadFormFile();

            if(r_LogicManager.AppSettings.RememberUser)
            {
                r_LogicManager.ConnectFromXml();
            }
            else
            {
                r_LogicManager.Login();

                if (rememberMeChoiceBox.CheckState == CheckState.Checked)
                {
                    r_LogicManager.SaveUserAccessToken();
                }
            }

            loadUserData();
            allocateAllForms();
        }
        

        private void allocateAllForms()
        {
            m_LikedPagesForm = new LikedPagesForm(this.r_LogicManager.LoggedInUser);
            m_FavoriteTeamsForm = new FavoriteTeamsForm();
            m_GroupsForm = new GroupsForm();
            m_PostForm = new PostForm();


        }

        private void loadUserData()
        {

            if (string.IsNullOrEmpty(r_LogicManager.LoginResult.ErrorMessage))
            {
                loginButton.Text = $"Logged in as {r_LogicManager.LoggedInUser.Name}";
                loginButton.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = r_LogicManager.LoggedInUser.PictureNormalURL;
                
                rememberMeChoiceBox.Visible = false;
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            //fetchPosts();
        }

        private void likedPagesButton_Click(object sender, EventArgs e)
        {
            loadSubForm(m_LikedPagesForm);
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            r_LogicManager.Logout();
            FacebookService.LogoutWithUI();
            this.Visible = false;

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
