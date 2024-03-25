using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Employee
    {
        #region Properties
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }
        public string empDesigation { get; set; }
        #endregion

        #region Methods
        public double CalculateBonus(int percentage)
        {
            double bonus = (empSalary * percentage) / 100;
            return bonus;
        }

        public string ChangeDegisgnation(string newDesignation)
        {
            empDesigation = newDesignation;
            return empDesigation;
        }
        #endregion

        //public Employee()
        //{
        //    //can do some calculation / condition
        //    //eg. read the system date and time, and if it is saturday or sunday, do not create an object, as it is a bank holidys
        //}

        public Employee(int p_empNo, string p_empName, double p_salary, string p_empDesignation,bool p_empIsPermenant)
        {
            empNo = p_empNo;
            empName = p_empName;
            empSalary = p_salary;
            empDesigation = p_empDesignation;
            empIsPermenant = p_empIsPermenant;
        }
    }
}
