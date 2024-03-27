using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_demo
{
    internal class HR : EmployeeInfo
    {
        static int sv_autoNumberHR = 100;
        public HR(string p_empname,string p_empdesigantion):base(p_empname, p_empdesigantion)
        {
            sv_autoNumberHR = sv_autoNumberHR + 1;
            empNo = (p_empdesigantion.Substring(0,2) +  sv_autoNumberHR).ToUpper();
        }
    }
}
