using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_OOPS
{
    internal class Current : BankAccount
    {
        public Current() : base(101, "Default Name", "Current", true, 1000)
        {

        }
    }
}