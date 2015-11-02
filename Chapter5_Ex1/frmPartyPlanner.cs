using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5_Ex1
{
    public partial class frmPartyPlanner : Form
    {
        DinnerParty dinnerParty;

        public frmPartyPlanner()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { numberOfPeople = (int) nudNumberOfPeople.Value };
            dinnerParty.SetHealthyOption(cbHealthy.Checked);
            dinnerParty.CalculateCostOfDecorations(cbFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.CalculateCost(cbHealthy.Checked);
            tbCost.Text = cost.ToString("c");
        }

        private void nudNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.numberOfPeople = (int)nudNumberOfPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void cbFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(cbFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void cbHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(cbHealthy.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
