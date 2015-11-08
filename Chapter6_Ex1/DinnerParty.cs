using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Ex1
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }


         
        public const int costOfFoodPerPerson = 25;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }       

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
                costOfBeveragesPerPerson = 5.00M;
            else
                costOfBeveragesPerPerson = 20.00M;
            return costOfBeveragesPerPerson;
        }

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

        public decimal Cost 
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();

                totalCost += ((CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson) * NumberOfPeople);
                
                if (HealthyOption)
                    return totalCost * 0.95M;
                else
                    return totalCost;
            }
        }
    }
}
