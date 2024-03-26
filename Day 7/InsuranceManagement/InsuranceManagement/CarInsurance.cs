using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement
{
    internal class CarInsurance : Insurance
    {
        public override double CalculateRenewalPremieum(int p_age, double p_insuranceValue)
        {

            if (p_age <= 1)
            {
                return p_insuranceValue * 0.15;
            }
            else if (p_age >1 && p_age <=5 )
            {
                return p_insuranceValue * 0.5;
            }
            else
            {
                return p_insuranceValue;
            }
               return base.CalculateRenewalPremieum(p_age, p_insuranceValue);

        }
    }
}
