using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FavoriteTeamsForm : Form
    {
        public FavoriteTeamsForm()
        {
            InitializeComponent();
        }

        public void FetchTeams(Page[] i_Teams)
        {
            listBoxTeams.Items.Clear();
            listBoxTeams.DisplayMember = "Name";

            foreach (Page team in i_Teams)
            {
                listBoxTeams.Items.Add(team);
            }

            if (listBoxTeams.Items.Count == 0)
            {
                MessageBox.Show("No teams to retrieve :(");
            }
        }

        private void listBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeams.SelectedItems.Count == 1)
            {
                Page selectedTeam = listBoxTeams.SelectedItem as Page;
                teamsPictureBox.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }
    }
}
