using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Ex1
{
    class DinnerParty
    {
        public int numberOfPeople;
        public decimal costOfBeveragesPerPerson;
        public decimal costOfDecorations = 0;

        public const int costOfFoodPerPerson = 25;

        public void SetHealthyOption(bool healthy)
        {
            if (healthy)
                costOfBeveragesPerPerson = 5.00M;
            else
                costOfBeveragesPerPerson = 20.00M;
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                costOfDecorations = (numberOfPeople * 15.00M) + 50.00M;
            else
                costOfDecorations = (numberOfPeople * 7.50M) + 30.00M;
        }

        public decimal CalculateCost(bool healthy)
        {
            decimal cost = 0.00M;

            cost = (numberOfPeople * (costOfFoodPerPerson + costOfBeveragesPerPerson)) + costOfDecorations;
            if (healthy)
                return cost * 0.95M;
            else
                return cost;

        }
    }
}
