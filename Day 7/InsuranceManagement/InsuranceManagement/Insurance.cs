using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement
{
    internal abstract class Insurance
    {
        //by default this method as it is inherited by childrens
        //but we want differnt behaviour in child classes for this method so we will mark it as virtual
        public virtual double CalculateRenewalPremieum(int p_age, double p_insuranceValue)
        {
            if (p_insuranceValue < 10000)
            {
                throw new Exception("Minimum Insurance should be 10000");
            }
            else if (p_insuranceValue > 2000000)
            {
                throw new Exception("Maximum Insurance value should be 2000000");
            }
            return p_insuranceValue;
        }
    }
}
