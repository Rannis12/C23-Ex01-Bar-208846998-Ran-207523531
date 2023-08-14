
namespace BasicFacebookFeatures.SubForms
{
    partial class AlbumsForm
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
            this.likedPagesLabel = new System.Windows.Forms.Label();
            this.albumsPages = new System.Windows.Forms.ListBox();
            this.albumsPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.albumsPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // likedPagesLabel
            // 
            this.likedPagesLabel.AutoSize = true;
            this.likedPagesLabel.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.likedPagesLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.likedPagesLabel.Location = new System.Drawing.Point(214, 9);
            this.likedPagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likedPagesLabel.Name = "likedPagesLabel";
            this.likedPagesLabel.Size = new System.Drawing.Size(144, 47);
            this.likedPagesLabel.TabIndex = 72;
            this.likedPagesLabel.Text = "Albums";
            // 
            // albumsPages
            // 
            this.albumsPages.DisplayMember = "name";
            this.albumsPages.FormattingEnabled = true;
            this.albumsPages.ItemHeight = 16;
            this.albumsPages.Location = new System.Drawing.Point(4, 4);
            this.albumsPages.Margin = new System.Windows.Forms.Padding(4);
            this.albumsPages.Name = "albumsPages";
            this.albumsPages.Size = new System.Drawing.Size(467, 308);
            this.albumsPages.TabIndex = 70;
            this.albumsPages.SelectedIndexChanged += new System.EventHandler(this.albumsPages_SelectedIndexChanged);
            // 
            // albumsPictureBox
            // 
            this.albumsPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.albumsPictureBox.Location = new System.Drawing.Point(474, 101);
            this.albumsPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.albumsPictureBox.Name = "albumsPictureBox";
            this.albumsPictureBox.Size = new System.Drawing.Size(136, 109);
            this.albumsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumsPictureBox.TabIndex = 71;
            this.albumsPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.albumsPages);
            this.panel1.Controls.Add(this.albumsPictureBox);
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 325);
            this.panel1.TabIndex = 73;
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.likedPagesLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlbumsForm";
            this.Text = "Albums";
            ((System.ComponentModel.ISupportInitialize)(this.albumsPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label likedPagesLabel;
        private System.Windows.Forms.PictureBox albumsPictureBox;
        private System.Windows.Forms.ListBox albumsPages;
        private System.Windows.Forms.Panel panel1;
    }
}