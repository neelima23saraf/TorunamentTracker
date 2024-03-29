﻿using System;
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
    public partial class CreateTournament : Form, IPriceForm
    {
        List<TeamModel> availableTeams = GlobalConfig.Connections.GetTeams();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrize = new List<PrizeModel>();
        public CreateTournament()
        {
            InitializeComponent();
            selectedTeamDropDown();

        }

        private void selectedTeamDropDown()
        {
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentPlayersListBox.DataSource = selectedTeams;
            tournamentPlayersListBox.DisplayMember = "TeamName";

        }

        private void wireUp()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";


            tournamentPlayersListBox.DataSource = null;
            tournamentPlayersListBox.DataSource = selectedTeams;
            tournamentPlayersListBox.DisplayMember = "TeamName";

            //add the prize in the text box

            tournamentPrizesListBox.DataSource = null;
            tournamentPrizesListBox.DataSource = selectedPrize;
            tournamentPrizesListBox.DisplayMember = "PlaceName";

        }
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            if (selectTeamDropDown.SelectedItem != null)
            {
                availableTeams.Remove((TeamModel)selectTeamDropDown.SelectedItem);
                selectedTeams.Add((TeamModel)selectTeamDropDown.SelectedItem);
                wireUp();
            }


        }

        private void deleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            if (tournamentPlayersListBox.SelectedItem != null)
            {
                availableTeams.Add((TeamModel)tournamentPlayersListBox.SelectedItem);
                selectedTeams.Remove((TeamModel)tournamentPlayersListBox.SelectedItem);
                wireUp();
            }
        }

        private void deleteSelectedPrizeButton_Click(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm createPrizeForm = new CreatePrizeForm(this);
            createPrizeForm.Show();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {

        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void PrizeComplete(PrizeModel prizeModel)
        {
            selectedPrize.Add(prizeModel);
            wireUp();

        }
    }
}
