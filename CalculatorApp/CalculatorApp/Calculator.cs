using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorApp
{
    class Calculator
    {
        public double Add(double firstNo, double secondNo)
        {
            return firstNo + secondNo;
        }

        public double Subtract(double firstNo, double secondNo)
        {
            return firstNo - secondNo;
        }
        public double Multiply(double firstNo, double secondNo)
        {
            return firstNo * secondNo;
        }
        public double Divide(double firstNo, double secondNo)
        {
            if (secondNo == 0)
            {
                throw new DivideByZeroException();
            }
            return firstNo / secondNo;
        }

    }
}
