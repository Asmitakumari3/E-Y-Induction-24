using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    internal interface IBanking
    {
        double Withdraw(int amount);
        double Deposit(int amount);
        double Transfer(int fromAccNo, int ToAccNo, double amount);

        string OpenFD(double FDValue);

        string BuyMF(double value, string mutualFundName);

        string ApplyATMPIN();
        string ApplyChecqeBook();
    }
}
