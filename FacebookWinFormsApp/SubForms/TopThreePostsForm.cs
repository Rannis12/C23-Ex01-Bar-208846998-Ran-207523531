using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.SubForms
{
    public partial class TopThreePostsForm : Form
    {
        public TopThreePostsForm()
        {
            InitializeComponent();
        }

        internal void FetchTopThreePosts(FacebookObjectCollection<Post> i_Posts)
        {
            Post topPost = null;
            Post midPost = null;
            Post lastPost = null;

            int topPostCount = 0;
            int midPostCount = 0;
            int lastPostCount = 0;

            foreach (Post post in i_Posts)
            {
                if (topPostCount < post.Comments.Count)
                {
                    lastPostCount = midPostCount;
                    lastPost = midPost;
                    midPostCount = topPostCount;
                    midPost = topPost;
                    topPostCount = post.Comments.Count;
                    topPost = post;
                }
                else if(midPostCount < post.Comments.Count)
                {
                    lastPostCount = midPostCount;
                    lastPost = midPost;
                    midPostCount = post.Comments.Count;
                    midPost = post;
                }
                else if(lastPostCount < post.Comments.Count)
                {
                    lastPostCount = post.Comments.Count;
                    lastPost = post;
                }
            }

           // topPostTextBox.Text = topPost.Caption;
        }
    }
}
