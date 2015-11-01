using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Bet
    {
        public int amount;
        public int dog;
        public Guy bettor;


        public Bet (Guy guy)
        {
            bettor = guy;
            amount = 0;
        }
        public Bet (int Amount, int Dog, Guy guy)
        {
            amount = Amount;
            dog = Dog;
            bettor = guy;
        }

        public string GetDescription()
        {
            //return string that says who placed be, how much
            // and which dog
            // "Joe bets 8 on dog #4"
            // if zero no bet
            // "Joe hasnt placed a bet
            if (amount <= 0)
            {
                return bettor.name + " hasnt placed a bet";
            }
            else
            {
                return bettor.name + " bets €" + amount + " on dog #" + (dog+1);
            }

        }

        public int PayOut (int Winner)
        {
            // if won, pay double
            // if lost, negative
            if (Winner == dog)            
                return amount;            
            else
                return amount * -1;
        }
    }
}
