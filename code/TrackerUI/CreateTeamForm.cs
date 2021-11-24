using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Mandatory fields are missing");
            }

            PersonModel person = new PersonModel(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, cellTextBox.Text);

            TrackerLibrary.GlobalConfig.Connections.CreatePerson(person);

            firstNameTextBox.Text="";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            cellTextBox.Text = "";

            

            

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
    }
}
