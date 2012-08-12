using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    public class Sinus : Function
    {
        public override double Calc(double val)
        {
            return Math.Sin(val);
        }

        public override Function Derivative()
        {
            return Funcs.Cos;
        }

        public override string ToString()
        {
            return "sin x";
        }
    }
}
