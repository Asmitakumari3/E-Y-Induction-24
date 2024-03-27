using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    internal class BankAccount : IAccountServices, ITransaction, IInvestment
    {
        public double accountBalance { get; set; } = 5000;
        public string ApplyATMPIN()
        {
            return "ATM pin is applied";
        }

        public string ApplyChecqeBook()
        {
            return "Cheque book applied";
        }

        public string BuyMF(double value, string mutualFundName)
        {
            return "MF added to your Portfolio";
        }

        public double Deposit(int amount)
        {
            accountBalance = accountBalance + amount;
            return accountBalance;
        }

        public string OpenFD(double FDValue)
        {
            return "FD is opend Successfully";
        }

        public double Transfer(int fromAccNo, int ToAccNo, double amount)
        {
            return accountBalance;
        }

        public double Withdraw(int amount)
        {
            accountBalance = accountBalance - amount;
            return accountBalance;
        }
    }
}
