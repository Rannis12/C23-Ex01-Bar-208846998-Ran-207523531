
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
            this.albumsPictureBox = new System.Windows.Forms.PictureBox();
            this.albumsPages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // likedPagesLabel
            // 
            this.likedPagesLabel.AutoSize = true;
            this.likedPagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPagesLabel.Location = new System.Drawing.Point(280, 16);
            this.likedPagesLabel.Name = "likedPagesLabel";
            this.likedPagesLabel.Size = new System.Drawing.Size(142, 42);
            this.likedPagesLabel.TabIndex = 72;
            this.likedPagesLabel.Text = "Albums";
            // 
            // albumsPictureBox
            // 
            this.albumsPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.albumsPictureBox.Location = new System.Drawing.Point(629, 132);
            this.albumsPictureBox.Name = "albumsPictureBox";
            this.albumsPictureBox.Size = new System.Drawing.Size(131, 106);
            this.albumsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumsPictureBox.TabIndex = 71;
            this.albumsPictureBox.TabStop = false;
            // 
            // albumsPages
            // 
            this.albumsPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumsPages.DisplayMember = "name";
            this.albumsPages.FormattingEnabled = true;
            this.albumsPages.Location = new System.Drawing.Point(40, 132);
            this.albumsPages.Name = "albumsPages";
            this.albumsPages.Size = new System.Drawing.Size(533, 303);
            this.albumsPages.TabIndex = 70;
            this.albumsPages.SelectedIndexChanged += new System.EventHandler(this.albumsPages_SelectedIndexChanged);
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.likedPagesLabel);
            this.Controls.Add(this.albumsPictureBox);
            this.Controls.Add(this.albumsPages);
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.albumsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label likedPagesLabel;
        private System.Windows.Forms.PictureBox albumsPictureBox;
        private System.Windows.Forms.ListBox albumsPages;
    }
}