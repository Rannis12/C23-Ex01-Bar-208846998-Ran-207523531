
namespace BasicFacebookFeatures.SubForms
{
    partial class FavoriteTeamsForm
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
            this.teamsPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.teamsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // likedPagesLabel
            // 
            this.likedPagesLabel.AutoSize = true;
            this.likedPagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPagesLabel.Location = new System.Drawing.Point(277, 19);
            this.likedPagesLabel.Name = "likedPagesLabel";
            this.likedPagesLabel.Size = new System.Drawing.Size(232, 42);
            this.likedPagesLabel.TabIndex = 72;
            this.likedPagesLabel.Text = "Liked Teams";
            // 
            // teamsPictureBox
            // 
            this.teamsPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.teamsPictureBox.Location = new System.Drawing.Point(510, 135);
            this.teamsPictureBox.Name = "teamsPictureBox";
            this.teamsPictureBox.Size = new System.Drawing.Size(131, 106);
            this.teamsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teamsPictureBox.TabIndex = 71;
            this.teamsPictureBox.TabStop = false;
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTeams.DisplayMember = "name";
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.Location = new System.Drawing.Point(37, 135);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(426, 303);
            this.listBoxTeams.TabIndex = 70;
            this.listBoxTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxTeams_SelectedIndexChanged);
            // 
            // FavoriteTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.likedPagesLabel);
            this.Controls.Add(this.teamsPictureBox);
            this.Controls.Add(this.listBoxTeams);
            this.Name = "FavoriteTeamsForm";
            this.Text = "FavoriteTeamsForm";
            ((System.ComponentModel.ISupportInitialize)(this.teamsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label likedPagesLabel;
        private System.Windows.Forms.PictureBox teamsPictureBox;
        private System.Windows.Forms.ListBox listBoxTeams;
    }
}