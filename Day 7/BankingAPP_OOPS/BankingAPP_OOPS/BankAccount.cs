using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_OOPS
{
    internal abstract class BankAccount 
    {
        public double accBalance { get; set; }
        
        //child classes will inherit all the properties
        //Methods

        //we have 2 child classes, savings and current
        // we want to achive different behaviour for Withdraw in both the class

        //Savings can withdraw max, 20000, current can withdraw max 100000
        //savings can with only from the availabe balance (i.e, if they have 15000 they can withdar max 15k and not 20k)

        //Current account can withdraw max 1 lakh even if they do not have the sufficient balance (they get OD-overdraft facility)

        //to achive this,
        //we mark Method as Virtual in parent class
        //and overrides in child class
        public virtual double Withdraw(int amount)
        {
            accBalance = accBalance - amount;
            return accBalance;

        }

        public double Deposit(int amount) 
        {
            accBalance = accBalance + amount;
            return accBalance;
        }

        public string Greet()
        {
            return "Hello and Welcome";
        }
    }
}
