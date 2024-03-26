using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement
{
    internal class LifeInsurance : Insurance
    {
        public override double CalculateRenewalPremieum(int p_age, double p_insuranceValue)
        {
            if (p_age >= 1 && p_age <=30)
            {
                return p_insuranceValue * 0.08;
            }
            else if(p_age > 30 && p_age <= 60)
            {
                return p_insuranceValue * 0.3;
            }
            else if(p_age > 60 && p_age <= 75)
            {
                return p_insuranceValue * 0.4;
            }
            else if(p_age > 75)
            {
                throw new Exception("Sorry We Cannot insure you");
            }

            return base.CalculateRenewalPremieum(p_age, p_insuranceValue);
        }
    }
}
