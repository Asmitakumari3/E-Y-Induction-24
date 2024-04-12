using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Basics2
{
    internal class Employee
    {
        //Decalare a variable and never use it outside the class
        #region Variables

        int v_empNo;
        string v_empName;
        double v_empSalary;
        int v_empAge;
        bool v_empIsPermenant;
        #endregion


        public double EmployeeSalary
        {
            get { return v_empSalary; }
            set { v_empSalary = value;}
        }
        public int EmpNo
        {
            get
            {
                //you can do any programming here
                return v_empNo;
            }
            set
            {
                //you can put a condition
                //you put a loop
                //you can handle exception
                //do some caluation
                //raise an event 
                v_empNo = value;
            }
        }

        public string EmpName
        {
            get
            {
                return v_empName;
            }
            set
            { 
                v_empName = value; 
            }
        }



    }
}
