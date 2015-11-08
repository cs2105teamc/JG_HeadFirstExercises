using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6_Ex1
{
    public partial class frmPartyPlanner : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public frmPartyPlanner()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)nudNumberOfPeople.Value, cbHealthy.Checked, cbFancy.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)nudBirthday.Value, cbFancyBirthday.Checked, tbCakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            lbTooLong.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            tbBirthdayCost.Text = cost.ToString("c");
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

        private void nudBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)nudBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void cbFancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = cbFancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void tbCakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = tbCakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
