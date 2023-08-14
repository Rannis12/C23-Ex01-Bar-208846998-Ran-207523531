
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
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.teamsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.teamsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // likedPagesLabel
            // 
            this.likedPagesLabel.AutoSize = true;
            this.likedPagesLabel.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.likedPagesLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.likedPagesLabel.Location = new System.Drawing.Point(164, 9);
            this.likedPagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likedPagesLabel.Name = "likedPagesLabel";
            this.likedPagesLabel.Size = new System.Drawing.Size(271, 47);
            this.likedPagesLabel.TabIndex = 72;
            this.likedPagesLabel.Text = "Favorite Teams";
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTeams.DisplayMember = "name";
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.ItemHeight = 16;
            this.listBoxTeams.Location = new System.Drawing.Point(10, 72);
            this.listBoxTeams.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(466, 308);
            this.listBoxTeams.TabIndex = 70;
            this.listBoxTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxTeams_SelectedIndexChanged);
            // 
            // teamsPictureBox
            // 
            this.teamsPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.teamsPictureBox.Location = new System.Drawing.Point(486, 156);
            this.teamsPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.teamsPictureBox.Name = "teamsPictureBox";
            this.teamsPictureBox.Size = new System.Drawing.Size(125, 111);
            this.teamsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teamsPictureBox.TabIndex = 71;
            this.teamsPictureBox.TabStop = false;
            // 
            // FavoriteTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 393);
            this.Controls.Add(this.likedPagesLabel);
            this.Controls.Add(this.teamsPictureBox);
            this.Controls.Add(this.listBoxTeams);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FavoriteTeamsForm";
            this.Text = "Favorite Teams ";
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