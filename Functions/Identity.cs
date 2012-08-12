using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    public class Identity : Function
    {
        public override double Calc(double val)
        {
            return val;
        }

        public override Function Derivative()
        {
            return Funcs.Zero + 1;
        }

        public override string ToString()
        {
            return "x";
        }
    }
}
