using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    public class Cosinus : Function
    {
        public override double Calc(double val)
        {
            return Math.Cos(val);
        }

        public override Function Derivative()
        {
            return -1 * Funcs.Sin;
        }

        public override string ToString()
        {
            return "cos x";
        }
    }
}
