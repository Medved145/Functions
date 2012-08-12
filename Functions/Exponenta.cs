using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    public class Exponenta : Function
    {
        public Exponenta(double a = Math.E)
        {
            this.a = a;
        }

        public override double Calc(double val)
        {
            return Math.Pow(a, val);
        }

        public override Function Derivative()
        {
            return new Constant(Math.Log(a, Math.E)) * this;
        }

        public override string ToString()
        {
            if (Math.Abs(a - Math.E) <= 10e-6)
                return "e^x";
            return a + "^x";
        }

        private double a;
    }
}
