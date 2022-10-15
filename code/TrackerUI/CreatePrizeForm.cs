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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPriceForm callingForm;
        public CreatePrizeForm(IPriceForm caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //Initilize PrizeModel Object
                PrizeModel model = new PrizeModel(placeNumberTextBox.Text, placeNameTextBox.Text, prizeAmountTextBox.Text, prizePercentageTextBox.Text);

                 GlobalConfig.Connections.CreatePrize(model);
                callingForm.PrizeComplete(model);
                this.Close();

                //placeNumberTextBox.Text = "";
                //placeNameTextBox.Text = "";
                //prizeAmountTextBox.Text = "0";
                //prizePercentageTextBox.Text ="0";
            }
            else {
                MessageBox.Show("Please check your inputs.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidation = int.TryParse(placeNumberTextBox.Text, out placeNumber);

            if (!(placeNumberValidation) || (placeNameTextBox.Text.Length == 0) || placeNumber < 1)
            { 
                output = false;
            }

            decimal priceAmount = 0;
            double pricePercentage = 0;

            bool priceAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out priceAmount);
            bool pricePercentageValid = double.TryParse(prizePercentageTextBox.Text, out pricePercentage);

            if (!(priceAmountValid) || !(pricePercentageValid))
            {
                output = false;
            }

            if (priceAmount <= 0 && pricePercentage <= 0)
            {
                output = false;
            }

            if (pricePercentage < 0 || pricePercentage > 100)
            {
                output = false;
            }
        return output;
        }
    }
}
