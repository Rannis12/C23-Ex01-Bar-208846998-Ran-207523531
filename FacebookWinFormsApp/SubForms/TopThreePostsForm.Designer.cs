
namespace BasicFacebookFeatures.SubForms
{
    partial class TopThreePostsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopThreePostsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.firstTopLikesAmountLabel = new System.Windows.Forms.Label();
            this.secondTopLikesAmountLabel = new System.Windows.Forms.Label();
            this.thirdTopLikesAmountLabel = new System.Windows.Forms.Label();
            this.topPostTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(289, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 129);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(530, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 129);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // firstTopLikesAmountLabel
            // 
            this.firstTopLikesAmountLabel.AutoSize = true;
            this.firstTopLikesAmountLabel.Location = new System.Drawing.Point(54, 219);
            this.firstTopLikesAmountLabel.Name = "firstTopLikesAmountLabel";
            this.firstTopLikesAmountLabel.Size = new System.Drawing.Size(137, 17);
            this.firstTopLikesAmountLabel.TabIndex = 3;
            this.firstTopLikesAmountLabel.Text = "firstTopLikesAmount";
            // 
            // secondTopLikesAmountLabel
            // 
            this.secondTopLikesAmountLabel.AutoSize = true;
            this.secondTopLikesAmountLabel.Location = new System.Drawing.Point(292, 219);
            this.secondTopLikesAmountLabel.Name = "secondTopLikesAmountLabel";
            this.secondTopLikesAmountLabel.Size = new System.Drawing.Size(160, 17);
            this.secondTopLikesAmountLabel.TabIndex = 4;
            this.secondTopLikesAmountLabel.Text = "secondTopLikesAmount";
            // 
            // thirdTopLikesAmountLabel
            // 
            this.thirdTopLikesAmountLabel.AutoSize = true;
            this.thirdTopLikesAmountLabel.Location = new System.Drawing.Point(541, 219);
            this.thirdTopLikesAmountLabel.Name = "thirdTopLikesAmountLabel";
            this.thirdTopLikesAmountLabel.Size = new System.Drawing.Size(142, 17);
            this.thirdTopLikesAmountLabel.TabIndex = 5;
            this.thirdTopLikesAmountLabel.Text = "thirdTopLikesAmount";
            // 
            // topPostTextBox
            // 
            this.topPostTextBox.Location = new System.Drawing.Point(46, 282);
            this.topPostTextBox.Name = "topPostTextBox";
            this.topPostTextBox.Size = new System.Drawing.Size(641, 65);
            this.topPostTextBox.TabIndex = 6;
            this.topPostTextBox.Text = "";
            // 
            // TopThreePostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topPostTextBox);
            this.Controls.Add(this.thirdTopLikesAmountLabel);
            this.Controls.Add(this.secondTopLikesAmountLabel);
            this.Controls.Add(this.firstTopLikesAmountLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopThreePostsForm";
            this.Text = "Your Top Three Photos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label firstTopLikesAmountLabel;
        private System.Windows.Forms.Label secondTopLikesAmountLabel;
        private System.Windows.Forms.Label thirdTopLikesAmountLabel;
        private System.Windows.Forms.RichTextBox topPostTextBox;
    }
}