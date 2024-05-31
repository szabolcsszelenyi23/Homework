using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Insurance
    {
        private const int mandatoryInsuranceCost = 5;
        private const int additionalInsuranceCost = 2;
        private const double noAdditionalInsuranceSurcharge = 0.10;

        public bool HasAdditionalInsurance { get; set; }

        public Insurance(bool hasAdditionalInsurance)
        {
            HasAdditionalInsurance = hasAdditionalInsurance;
        }

        public int CalculateMonthlyCost()
        {
            int monthlyCost = mandatoryInsuranceCost;
            if (HasAdditionalInsurance)
            {
                monthlyCost += additionalInsuranceCost;
            }
            return monthlyCost;
        }

        public double CalculateFinalPrice(double carPrice)
        {
            if (!HasAdditionalInsurance)
            {
                return carPrice * (1 + noAdditionalInsuranceSurcharge);
            }
            return carPrice;
        }
    }
}
