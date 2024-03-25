using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_OOPS
{
    internal class Savings : BankAccount
    {

        public double intrestRate { get; set; }

        public string ApplyATMPIN()
        {
            return "PIN Applied";
        }
        public Savings(int p_acNo, string p_acName, string p_acType, bool p_acIsActive, double p_acBal) : base(p_acNo, p_acName, p_acType, p_acIsActive, p_acBal)
        {
           
        }
    }
    
}
