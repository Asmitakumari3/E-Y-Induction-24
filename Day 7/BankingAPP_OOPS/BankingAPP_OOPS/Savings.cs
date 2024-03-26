using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_OOPS
{
    internal class Savings : BankAccount
    {

        public override double Withdraw(int amount)
        {
            if(amount > 20000)
            {
                throw new Exception("You can withdraw max 20000 in a transaction");
            }
            if(amount > accBalance)
            {
                throw new Exception("Insufficent Balance");
            }

           // accBalance = accBalance - amount;
           // return accBalance;

            //why to repeat same code which is return in parent - instead
            return base.Withdraw(amount);
        }
    }
}
