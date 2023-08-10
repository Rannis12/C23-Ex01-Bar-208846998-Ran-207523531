
namespace BasicFacebookFeatures
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.compenentsPanel = new System.Windows.Forms.Panel();
            this.dialogPanel = new System.Windows.Forms.Panel();
            this.rememberMeChoiceBox = new System.Windows.Forms.CheckBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.albumsButton = new System.Windows.Forms.Button();
            this.favoriteTeamsButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.likedPagesButton = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.dialogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // compenentsPanel
            // 
            this.compenentsPanel.Location = new System.Drawing.Point(298, 1);
            this.compenentsPanel.Name = "compenentsPanel";
            this.compenentsPanel.Size = new System.Drawing.Size(923, 592);
            this.compenentsPanel.TabIndex = 0;
            // 
            // dialogPanel
            // 
            this.dialogPanel.Controls.Add(this.rememberMeChoiceBox);
            this.dialogPanel.Controls.Add(this.usernameLabel);
            this.dialogPanel.Controls.Add(this.button6);
            this.dialogPanel.Controls.Add(this.albumsButton);
            this.dialogPanel.Controls.Add(this.favoriteTeamsButton);
            this.dialogPanel.Controls.Add(this.groupsButton);
            this.dialogPanel.Controls.Add(this.likedPagesButton);
            this.dialogPanel.Controls.Add(this.postButton);
            this.dialogPanel.Controls.Add(this.logoutButton);
            this.dialogPanel.Controls.Add(this.loginButton);
            this.dialogPanel.Controls.Add(this.pictureBoxProfile);
            this.dialogPanel.Location = new System.Drawing.Point(1, 1);
            this.dialogPanel.Name = "dialogPanel";
            this.dialogPanel.Size = new System.Drawing.Size(297, 591);
            this.dialogPanel.TabIndex = 1;
            // 
            // rememberMeChoiceBox
            // 
            this.rememberMeChoiceBox.AutoSize = true;
            this.rememberMeChoiceBox.Location = new System.Drawing.Point(94, 9);
            this.rememberMeChoiceBox.Name = "rememberMeChoiceBox";
            this.rememberMeChoiceBox.Size = new System.Drawing.Size(95, 17);
            this.rememberMeChoiceBox.TabIndex = 11;
            this.rememberMeChoiceBox.Text = "Remember Me";
            this.rememberMeChoiceBox.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(126, 163);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "label1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 428);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(278, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // albumsButton
            // 
            this.albumsButton.Location = new System.Drawing.Point(8, 386);
            this.albumsButton.Name = "albumsButton";
            this.albumsButton.Size = new System.Drawing.Size(278, 36);
            this.albumsButton.TabIndex = 8;
            this.albumsButton.Text = "Albums";
            this.albumsButton.UseVisualStyleBackColor = true;
            // 
            // favoriteTeamsButton
            // 
            this.favoriteTeamsButton.Location = new System.Drawing.Point(8, 344);
            this.favoriteTeamsButton.Name = "favoriteTeamsButton";
            this.favoriteTeamsButton.Size = new System.Drawing.Size(278, 36);
            this.favoriteTeamsButton.TabIndex = 7;
            this.favoriteTeamsButton.Text = "Teams";
            this.favoriteTeamsButton.UseVisualStyleBackColor = true;
            // 
            // groupsButton
            // 
            this.groupsButton.Location = new System.Drawing.Point(8, 302);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(278, 36);
            this.groupsButton.TabIndex = 6;
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = true;
            // 
            // likedPagesButton
            // 
            this.likedPagesButton.Location = new System.Drawing.Point(8, 260);
            this.likedPagesButton.Name = "likedPagesButton";
            this.likedPagesButton.Size = new System.Drawing.Size(278, 36);
            this.likedPagesButton.TabIndex = 5;
            this.likedPagesButton.Text = "Liked Pages";
            this.likedPagesButton.UseVisualStyleBackColor = true;
            this.likedPagesButton.Click += new System.EventHandler(this.likedPagesButton_Click);
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(7, 218);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(278, 36);
            this.postButton.TabIndex = 4;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(110, 554);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 27);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(3, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 27);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(84, 38);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(121, 106);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 594);
            this.Controls.Add(this.dialogPanel);
            this.Controls.Add(this.compenentsPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.dialogPanel.ResumeLayout(false);
            this.dialogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel compenentsPanel;
        private System.Windows.Forms.Panel dialogPanel;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button albumsButton;
        private System.Windows.Forms.Button favoriteTeamsButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button likedPagesButton;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox rememberMeChoiceBox;
    }
}