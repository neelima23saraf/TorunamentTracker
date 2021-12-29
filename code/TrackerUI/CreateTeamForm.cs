using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        List<PersonModel> selectdTeamMembers = new List<PersonModel>();
        List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetAllPerson();
        public CreateTeamForm()
        {
            InitializeComponent();
            selectTeamMemberDropDown.DataSource = null;
            teamMembersListBox.DataSource = null;

            WireUpList();
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void WireUpList()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectdTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }


        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, cellTextBox.Text);

                person = TrackerLibrary.GlobalConfig.Connections.CreatePerson(person);

                selectdTeamMembers.Add(person);

                WireUpList();

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                cellTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Mandatory fields are missing");
            }

            

        }

        private bool ValidateForm()
        {
            if (firstNameTextBox.Text.Length == 0 || (emailTextBox.Text.Length ==0) || (cellTextBox.Text.Length ==0))
                return false;

            if((cellTextBox.Text.Length < 1) || (cellTextBox.Text.Length > 11))
                return false;
            
            int cellPhone = 0;
            if(!int.TryParse(cellTextBox.Text, out cellPhone))
                return false;
         
            return  true;
        }

        private void aadTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectdTeamMembers.Add(p);

                WireUpList();
            }
            
        }

        private void removeSelectedTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectdTeamMembers.Remove(p);

                WireUpList();
            }
            
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = new TeamModel();

            team.TeamName = teamNameTextBox.Text;
            team.TeamMember = selectdTeamMembers;

            team = GlobalConfig.Connections.CreateTeam(team);


            teamNameTextBox.Text = "";
            teamMembersListBox.DataSource = null;

        }
    }
}
