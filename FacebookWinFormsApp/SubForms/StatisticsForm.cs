using FacebookLogic;
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
    public partial class StatisticsForm : Form
    {
        private readonly StatisticsHandler r_StatisticsHandler;
        public StatisticsForm(User i_LoggedInUser)
        {
            r_StatisticsHandler = new StatisticsHandler(i_LoggedInUser);
            InitializeComponent();
        }

        private void buttonShowStatistics_Click(object sender, EventArgs e)
        {
            int photosCount = 0;
            int postsCount = 0;
            int likesCount = 0;

            r_StatisticsHandler.FetchStatistics(yearSelectionLabel.Value.ToString(), photosCount, postsCount, likesCount);

            photosNumberLabel.Text = $"Photos count: {photosCount}";
            postsNumberLabel.Text = $"Posts count: {postsCount}";
            likesNumberLabel.Text = $"Likes count: {likesCount}";

        }
    }
}
