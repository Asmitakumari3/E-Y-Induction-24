using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_OOPS
{
    internal abstract class BankAccount
    {
        #region Properties
        public int accountNo { get; set; }
        public string accountName { get; set; }
        public double accountBalance { get; set; }
        public bool accountIsActive { get; set; }

        public string accountType { get; set; }
        #endregion

        #region Methods
        public double Withdraw(int amount)
        {
            accountBalance = accountBalance - amount;
            return accountBalance;
        }

        public double Deposit(int amount)
        {
            accountBalance = accountBalance + amount;
            return accountBalance;
        }
        #endregion

        #region Constructor
        public BankAccount(int p_accNo,string p_accName, string p_accType, bool p_accIsActive, double p_accBalance)
        {
            accountNo = p_accNo;
            accountName = p_accName;
            accountBalance = p_accBalance;
            accountIsActive = p_accIsActive;
            accountType = p_accType;

        }
        #endregion
    }
}
