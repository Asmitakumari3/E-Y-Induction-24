using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_OOPS
{
    internal class Current : BankAccount
    {


        public override double Withdraw(int amount)
        {
            if (amount > 100000) 
            {
                throw new Exception("You can withdraw max 100000 in a transaction");
            }
            return base.Withdraw(amount);
        }


    }
}
