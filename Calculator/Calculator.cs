using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
        
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        
        public double Multiple(double a, double b)
        {
            return a * b;
        }
     
        public double Divide(double a, double b)
        {
            if (a != 0)
                return a / b;
            else
                return 0;
        }
    }
}
