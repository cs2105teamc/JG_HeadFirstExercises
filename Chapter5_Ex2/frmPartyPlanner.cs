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
            dinnerParty = new DinnerParty((int)nudNumberOfPeople.Value, cbHealthy.Checked, cbFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            tbCost.Text = cost.ToString("c");
        }

        private void nudNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)nudNumberOfPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void cbFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = cbFancy.Checked;
            DisplayDinnerPartyCost();
        }

        private void cbHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = cbHealthy.Checked;
            DisplayDinnerPartyCost();
        }
    }
}
