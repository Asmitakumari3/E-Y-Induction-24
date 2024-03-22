using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Basics2
{
  


    internal class Calculations
    {
        //Method Overloading
        //Where name of the method is same, but parameters, return type, number of parameters are different
        //method overload can exist in same class or even when you have inheritance
        public int Add(int num1, int num2)
        { 
            return num1 + num2;
        }

        public string Add(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
        public double Add(int num1, double num2)
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2, int num3) 
        {
            return num1 + num2 + num3;
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        //there is a feature for C# - call Params Array


        public int Add(int num1, int num2,params int[] moreNumbers)
        {
            int result = num1 + num2;
            for (int i = 0; i < moreNumbers.Length; i++)
            {
                result = result + moreNumbers[i];
            }
            return result;
        }

        //default parameter value
        //named parameter
        
        public string AddEmployee(string empName,string lastName,string designation = "New Joinee", string dept = "Training")
        {
            //we will do some program like add to database
            return "Ëmployee Added Successfully" + empName + " is a " + designation + " in " + dept + " department";
        }


        public int CalculateNumbers(int num1, int num2,OperationType whichOperation) 
        {
            if(whichOperation.Equals(OperationType.Add)) 
            {
                return num1 + num2;
            }
            else if(whichOperation.Equals(OperationType.Subtract))
            {
                return num1 - num2;
            }
            else if(whichOperation.Equals(OperationType.Multiply))
            {
                return num1 * num2;
            }
            else if(whichOperation.Equals(OperationType.Divide))
            {
                return num1 / num2;
            }
            return 0;
        }    
    }
    enum OperationType
    {
        Add, Subtract, Divide, Multiply
    }
}
