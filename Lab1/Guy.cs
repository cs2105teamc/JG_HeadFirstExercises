using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public class Guy
    {
        public string name;
        public Bet myBet;
        public int cash;

        public RadioButton myRadioButton;
        public Label myLabel;

        public Guy(string Name, int Cash, RadioButton MyRb, Label MyLabel)
        {
            name = Name;
            cash = Cash;
            myRadioButton = MyRb;
            myLabel = MyLabel;
            myBet = new Bet(this);
            this.UpdateLabels();
        }

        public void UpdateLabels()
        {
            // set label to my bet and cash
            myRadioButton.Text = name + " has €" + cash;            
            myLabel.Text = myBet.GetDescription();
        }

        public void ClearBet()
        {
            myBet = new Bet(this);
            UpdateLabels();
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (BetAmount <= cash)
            {
                myBet = new Bet(BetAmount, DogToWin, this);
                UpdateLabels();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            //Pay out           
            cash += myBet.PayOut(Winner);

            //clear bet
            this.ClearBet();

            //update labels
            this.UpdateLabels();
        }

    }
}
