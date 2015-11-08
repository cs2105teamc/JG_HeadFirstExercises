using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Ex1
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        public const int costOfFoodPerPerson = 25;

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations = 0;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30;
            }
            return costOfDecorations;
        }


        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();

                totalCost += costOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }
    }
}
