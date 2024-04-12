using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_demo
{
    internal class Calculate
    {

        public int DivideNumbers(int num1, int num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException("We do not divide a number with 0");
            }
            if(num1 == 0)
            {
                throw new Exception("We do not process 0's");
            }
            if(num1 < 0 || num2 < 0)
            {
                throw new Exception("We do not process negative values");
            }
            return num1 / num2;
        }
    }
}
