using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_basics
{
    internal class Employee
    {
        //Variables
        //by default variables in a class are private and they should be kept private
        int v_empNo;
        string v_empName;
        double v_empSalary;
        bool v_empIsPermenant;
        public int v_empAge = 20;
        //constructor
        public Employee() 
        {
            v_empNo = 101;
            v_empName = "Nikhil";
            v_empSalary = 1000;
            v_empIsPermenant = true;
            //this values we generally do not hardcode, we pull them from a datatabase or collect them from user
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee Number " + v_empNo);
            Console.WriteLine("Employee Name " + v_empName);
            Console.WriteLine("Employee Salary " + v_empSalary);
            Console.WriteLine("Employee Is Permenant " + v_empIsPermenant);
        }
        public double IcrementSalary()
        {
           // Console.WriteLine("Old Salary " + v_empSalary);
            v_empSalary = v_empSalary + 3000;
          //  Console.WriteLine("New Salary " + v_empSalary);
            return v_empSalary; 
        }

    }


    
}




