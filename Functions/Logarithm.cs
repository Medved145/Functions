using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    /// <summary>
    /// Log (x) with base a
    /// </summary>
    public class Logarithm : Function
    {
        public Logarithm(double a = Math.E)
        {
            this.a = a;
        }

        public override double Calc(double val)
        {
            return Math.Log(val, a);
        }

        public override Function Derivative()
        {
            return 1 / (Funcs.Id * Math.Log(a, Math.E));
        }

        public override string ToString()
        {
            if(Math.Abs(a - Math.E) <= 10e-6)
                return "ln x";
            return "log[a](x)";
        }

        private double a;
    }
}
