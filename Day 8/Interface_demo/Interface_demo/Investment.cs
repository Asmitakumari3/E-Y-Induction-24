using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    internal class Investment : IBanking
    { 
        //this is not in a scope of investment
        public string ApplyATMPIN()
        {
            throw new NotImplementedException();
        }
        //this is not in a scope of investment
        public string ApplyChecqeBook()
        {
            throw new NotImplementedException();
        }

        public string BuyMF(double value, string mutualFundName)
        {
            throw new NotImplementedException();
        }

        public double Deposit(int amount)
        {
            throw new NotImplementedException();
        }

        public string OpenFD(double FDValue)
        {
            throw new NotImplementedException();
        }

        public double Transfer(int fromAccNo, int ToAccNo, double amount)
        {
            throw new NotImplementedException();
        }

        public double Withdraw(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
