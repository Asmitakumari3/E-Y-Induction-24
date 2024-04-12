using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    internal interface IInvestment
    {
        string OpenFD(double FDValue);

        string BuyMF(double value, string mutualFundName);
    }
}
