
namespace BasicFacebookFeatures.subForms
{
    partial class LikedPagesForm
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
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.likedPagesLabel = new System.Windows.Forms.Label();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPages
            // 
            this.listBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPages.DisplayMember = "name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(10, 72);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(466, 308);
            this.listBoxPages.TabIndex = 67;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // likedPagesLabel
            // 
            this.likedPagesLabel.AutoSize = true;
            this.likedPagesLabel.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.likedPagesLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.likedPagesLabel.Location = new System.Drawing.Point(207, 9);
            this.likedPagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likedPagesLabel.Name = "likedPagesLabel";
            this.likedPagesLabel.Size = new System.Drawing.Size(209, 47);
            this.likedPagesLabel.TabIndex = 69;
            this.likedPagesLabel.Text = "Liked Pages";
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPage.Location = new System.Drawing.Point(486, 156);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(125, 111);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPage.TabIndex = 68;
            this.pictureBoxPage.TabStop = false;
            // 
            // LikedPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 393);
            this.Controls.Add(this.likedPagesLabel);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.listBoxPages);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LikedPagesForm";
            this.Text = "LikedPagesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Label likedPagesLabel;
    }
}