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
    public partial class GroupsForm : Form
    {
        private FacebookObjectCollection<Group> m_Groups;
        public GroupsForm()
        {
            InitializeComponent();
        }

        public void FetchGroups(FacebookObjectCollection<Group> i_Groups)
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";
            m_Groups = i_Groups;

            try
            {
                foreach (Group group in m_Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
