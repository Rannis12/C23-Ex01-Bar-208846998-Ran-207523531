
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.feedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.Location = new System.Drawing.Point(520, 101);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(73, 24);
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
            this.listBoxPostComments.ItemHeight = 19;
            this.listBoxPostComments.Location = new System.Drawing.Point(96, 381);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(608, 61);
            this.listBoxPostComments.TabIndex = 83;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 19;
            this.listBoxPosts.Location = new System.Drawing.Point(96, 227);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(608, 137);
            this.listBoxPosts.TabIndex = 81;
            // 
            // publishDateDataLabel
            // 
            this.publishDateDataLabel.AutoSize = true;
            this.publishDateDataLabel.Location = new System.Drawing.Point(652, 199);
            this.publishDateDataLabel.Name = "publishDateDataLabel";
            this.publishDateDataLabel.Size = new System.Drawing.Size(28, 13);
            this.publishDateDataLabel.TabIndex = 85;
            this.publishDateDataLabel.Text = "date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "publish date:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(98, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(416, 111);
            this.richTextBox1.TabIndex = 89;
            this.richTextBox1.Text = "";
            // 
            // feedLabel
            // 
            this.feedLabel.AutoSize = true;
            this.feedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedLabel.Location = new System.Drawing.Point(334, 9);
            this.feedLabel.Name = "feedLabel";
            this.feedLabel.Size = new System.Drawing.Size(104, 42);
            this.feedLabel.TabIndex = 90;
            this.feedLabel.Text = "Feed";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.feedLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.publishDateDataLabel);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label feedLabel;
    }
}