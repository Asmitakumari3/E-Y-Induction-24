using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP
{
    internal class BankAccounts
    {
        #region Properties
        public int accNo { get; set; }

        public string accName { get; set; }

        public double accBalance { get; set; }

        public string accType { get; set; }

        public bool accIsActive { get; set; } //value will be stored in a private variable not known to anyone
                                              //property is a wrapper on a variable for encapsulation 
        #endregion


        public double Withdraw(int amount)
        {
            accBalance = accBalance - amount;
            return accBalance;
        }

        public double Deposit(int amount) 
        {
            accBalance = accBalance - amount;
            return accBalance;
        }

    }
}
