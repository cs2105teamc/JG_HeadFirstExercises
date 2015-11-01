using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmDayAtRaces : Form
    {
        Greyhound[] greyhounds = new Greyhound[4];
        Guy[] guys = new Guy[3];
        int minimumBet = 5;
        int maximumBet = 15;

        public frmDayAtRaces()
        {
            InitializeComponent();
            SetupGreyhounds();
            SetupGuys();

            lblMinimumBet.Text = "Minimum bet : €" + minimumBet;
            nudAmount.Minimum = minimumBet;
            nudAmount.Maximum = maximumBet;
            cbxDog.SelectedIndex = 0;
            rbJoe.Checked = true;
        }

        public void SetupGreyhounds()
        {
            greyhounds[0] = new Greyhound(pbDog0, pbRaceTrack.Width);
            greyhounds[1] = new Greyhound(pbDog1, pbRaceTrack.Width);
            greyhounds[2] = new Greyhound(pbDog2, pbRaceTrack.Width);
            greyhounds[3] = new Greyhound(pbDog3, pbRaceTrack.Width);

            for (int i = 0; i < greyhounds.Count(); i++)
            {
                cbxDog.Items.Add(i+1);
            }
        }

        public void SetupGuys()
        {
            guys[0] = new Guy("Joe", 50, rbJoe, lbJoe);
            guys[1] = new Guy("Bob", 75, rbBob, lbBob);
            guys[2] = new Guy("Al", 45, rbAl, lbAl);
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            if(rbJoe.Checked)
            {
                guys[0].PlaceBet((int) nudAmount.Value, cbxDog.SelectedIndex);
            }
            else if (rbBob.Checked)
            {
                guys[1].PlaceBet((int)nudAmount.Value, cbxDog.SelectedIndex);
            }
            else if (rbAl.Checked)
            {
                guys[2].PlaceBet((int)nudAmount.Value, cbxDog.SelectedIndex);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Name == "rbJoe" && ((RadioButton)sender).Checked)
            {
                lbName.Text = "Joe";
            }
            if (((RadioButton)sender).Name == "rbBob" && ((RadioButton)sender).Checked)
            {
                lbName.Text = "Bob";
            }
            if (((RadioButton)sender).Name == "rbAl" && ((RadioButton)sender).Checked)
            {
                lbName.Text = "Al";
            }
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            btnBets.Enabled = false;
            btnRace.Enabled = false;
            raceTimer.Enabled = true;
            raceTimer.Start();

        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {

            for(int i = 0; i < greyhounds.Count(); i++)
            {
                if (greyhounds[i].Run())
                {
                    raceTimer.Stop();
                    MessageBox.Show("Dog #" + (i+1) + " won the race!", "We have a winner", MessageBoxButtons.OK);
                    
                    for ( int x = 0; x < guys.Count(); x++)
                    {
                        guys[x].Collect(i);
                    }

                    for (int y = 0; y < greyhounds.Count(); y++)
                        greyhounds[y].TakeStartingPosition();

                    btnBets.Enabled = true;
                    btnRace.Enabled = true;               
                    break;
                }

            }
        }
    }
}
