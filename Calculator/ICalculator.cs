using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        double Sum(double a, double b);

        double Subtract(double a, double b);

        double Multiple(double a, double b);

        double Divide(double a, double b);
    }
}
