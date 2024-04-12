using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_demo
{
    internal abstract class EmployeeInfo
    {

        static int sv_autoEmpNo = 100; //this is bydefault 0 , u can assign your value if you want to 
        int age;  //default value ? - null


        public string empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }

        public EmployeeInfo(string p_empname, string p_empdesignation)
        {
            //first do all the validdation of data passed by user, like check name length, check value designaions
            empName = p_empname;
            empDesignation = p_empdesignation;

            sv_autoEmpNo = sv_autoEmpNo + 1;
            empNo =  (p_empdesignation.Substring(0,2) + sv_autoEmpNo).ToUpper();
        }
    }
}





