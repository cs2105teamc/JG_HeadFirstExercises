﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Ex1
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }


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


        override public decimal Cost 
        {
            get
            {
                decimal totalCost = base.Cost;

                totalCost += (CalculateCostOfBeveragesPerPerson() * NumberOfPeople);
                
                if (HealthyOption)
                    return totalCost * 0.95M;
                else
                    return totalCost;
            }
        }
    }
}
