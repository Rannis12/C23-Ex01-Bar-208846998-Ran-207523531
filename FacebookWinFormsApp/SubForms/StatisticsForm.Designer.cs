
namespace BasicFacebookFeatures.SubForms
{
    partial class StatisticsForm
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
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.yearSelectionLabel = new System.Windows.Forms.NumericUpDown();
            this.labelChooseDate = new System.Windows.Forms.Label();
            this.buttonShowStatistics = new System.Windows.Forms.Button();
            this.postsNumberLabel = new System.Windows.Forms.Label();
            this.photosNumberLabel = new System.Windows.Forms.Label();
            this.likesNumberLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearSelectionLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AutoSize = true;
            this.statisticsLabel.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.statisticsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.statisticsLabel.Location = new System.Drawing.Point(203, 9);
            this.statisticsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(166, 47);
            this.statisticsLabel.TabIndex = 73;
            this.statisticsLabel.Text = "Statistics";
            // 
            // yearSelectionLabel
            // 
            this.yearSelectionLabel.Location = new System.Drawing.Point(273, 84);
            this.yearSelectionLabel.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.yearSelectionLabel.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearSelectionLabel.Name = "yearSelectionLabel";
            this.yearSelectionLabel.Size = new System.Drawing.Size(120, 22);
            this.yearSelectionLabel.TabIndex = 75;
            this.yearSelectionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearSelectionLabel.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // labelChooseDate
            // 
            this.labelChooseDate.AutoSize = true;
            this.labelChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseDate.Location = new System.Drawing.Point(26, 79);
            this.labelChooseDate.Name = "labelChooseDate";
            this.labelChooseDate.Size = new System.Drawing.Size(220, 25);
            this.labelChooseDate.TabIndex = 76;
            this.labelChooseDate.Text = "Please choose a year";
            this.labelChooseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonShowStatistics.Location = new System.Drawing.Point(421, 79);
            this.buttonShowStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(175, 36);
            this.buttonShowStatistics.TabIndex = 77;
            this.buttonShowStatistics.Text = "Show Statistics";
            this.buttonShowStatistics.UseVisualStyleBackColor = true;
            this.buttonShowStatistics.Click += new System.EventHandler(this.buttonShowStatistics_Click);
            // 
            // postsNumberLabel
            // 
            this.postsNumberLabel.AutoSize = true;
            this.postsNumberLabel.Location = new System.Drawing.Point(121, 221);
            this.postsNumberLabel.Name = "postsNumberLabel";
            this.postsNumberLabel.Size = new System.Drawing.Size(86, 17);
            this.postsNumberLabel.TabIndex = 78;
            this.postsNumberLabel.Text = "Posts count:";
            // 
            // photosNumberLabel
            // 
            this.photosNumberLabel.AutoSize = true;
            this.photosNumberLabel.Location = new System.Drawing.Point(258, 221);
            this.photosNumberLabel.Name = "photosNumberLabel";
            this.photosNumberLabel.Size = new System.Drawing.Size(99, 17);
            this.photosNumberLabel.TabIndex = 79;
            this.photosNumberLabel.Text = "Photos count: ";
            // 
            // likesNumberLabel
            // 
            this.likesNumberLabel.AutoSize = true;
            this.likesNumberLabel.Location = new System.Drawing.Point(431, 221);
            this.likesNumberLabel.Name = "likesNumberLabel";
            this.likesNumberLabel.Size = new System.Drawing.Size(84, 17);
            this.likesNumberLabel.TabIndex = 80;
            this.likesNumberLabel.Text = "Likes count:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::FacebookWinFormsApp.Properties.Resources.post_icon_180537;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(133, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 45);
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::FacebookWinFormsApp.Properties.Resources.photo_stack_icon_icons_com_58273;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(273, 164);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 45);
            this.pictureBox5.TabIndex = 82;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FacebookWinFormsApp.Properties.Resources.liked_pages;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(431, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 45);
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 393);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.likesNumberLabel);
            this.Controls.Add(this.photosNumberLabel);
            this.Controls.Add(this.postsNumberLabel);
            this.Controls.Add(this.buttonShowStatistics);
            this.Controls.Add(this.labelChooseDate);
            this.Controls.Add(this.yearSelectionLabel);
            this.Controls.Add(this.statisticsLabel);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.yearSelectionLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.NumericUpDown yearSelectionLabel;
        private System.Windows.Forms.Label labelChooseDate;
        private System.Windows.Forms.Button buttonShowStatistics;
        private System.Windows.Forms.Label postsNumberLabel;
        private System.Windows.Forms.Label photosNumberLabel;
        private System.Windows.Forms.Label likesNumberLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}