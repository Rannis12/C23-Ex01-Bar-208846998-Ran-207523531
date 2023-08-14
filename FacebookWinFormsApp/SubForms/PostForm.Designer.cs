
namespace BasicFacebookFeatures.subForms
{
    partial class PostForm
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
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.publishDateDataLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusRichText = new System.Windows.Forms.RichTextBox();
            this.feedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.buttonSetStatus.Location = new System.Drawing.Point(526, 68);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(89, 39);
            this.buttonSetStatus.TabIndex = 88;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.UseWaitCursor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPostComments.DisplayMember = "name";
            this.listBoxPostComments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 24;
            this.listBoxPostComments.Location = new System.Drawing.Point(16, 302);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(591, 76);
            this.listBoxPostComments.TabIndex = 83;
            this.listBoxPostComments.SelectedIndexChanged += new System.EventHandler(this.listBoxPostComments_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(16, 194);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(591, 100);
            this.listBoxPosts.TabIndex = 81;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // publishDateDataLabel
            // 
            this.publishDateDataLabel.AutoSize = true;
            this.publishDateDataLabel.Location = new System.Drawing.Point(557, 169);
            this.publishDateDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publishDateDataLabel.Name = "publishDateDataLabel";
            this.publishDateDataLabel.Size = new System.Drawing.Size(36, 17);
            this.publishDateDataLabel.TabIndex = 85;
            this.publishDateDataLabel.Text = "date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "publish date:";
            // 
            // statusRichText
            // 
            this.statusRichText.Location = new System.Drawing.Point(130, 68);
            this.statusRichText.Margin = new System.Windows.Forms.Padding(4);
            this.statusRichText.Name = "statusRichText";
            this.statusRichText.Size = new System.Drawing.Size(389, 63);
            this.statusRichText.TabIndex = 89;
            this.statusRichText.Text = "";
            // 
            // feedLabel
            // 
            this.feedLabel.AutoSize = true;
            this.feedLabel.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.feedLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.feedLabel.Location = new System.Drawing.Point(245, 9);
            this.feedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feedLabel.Name = "feedLabel";
            this.feedLabel.Size = new System.Drawing.Size(99, 47);
            this.feedLabel.TabIndex = 90;
            this.feedLabel.Text = "Feed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11.2F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 91;
            this.label1.Text = "Post status:";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feedLabel);
            this.Controls.Add(this.statusRichText);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.publishDateDataLabel);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostForm";
            this.Text = "PostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label publishDateDataLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox statusRichText;
        private System.Windows.Forms.Label feedLabel;
        private System.Windows.Forms.Label label1;
    }
}