using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    public class Constant : Function
    {
        public Constant(double val)
        {
            value = val;
        }

        public override double Calc(double val)
        {
            return value;
        }

        public override Function Derivative()
        {
            return Funcs.Zero;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        private readonly double value;
    }
}
