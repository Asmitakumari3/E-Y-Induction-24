using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_demo
{
    internal class Manager : EmployeeInfo
    {
        static int sv_autoManagerNo = 500;
        public Manager(string p_empname, string p_empdesigantion) : base(p_empname, p_empdesigantion)
        {
            sv_autoManagerNo = sv_autoManagerNo + 1;
            empNo = (p_empdesigantion.Substring(0, 2) + sv_autoManagerNo).ToUpper();
        }
    }
}
