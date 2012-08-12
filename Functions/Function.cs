using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    public abstract class Function
    {
        public abstract double Calc(double val);
        public abstract Function Derivative();

        /// <summary>
        /// n - derivative of function
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Function this[int n]
        {
            get
            {
                if (n < 0)
                    throw new ArgumentException("n must be more than zero");
                var f = this;
                for (int i = 0; i < n; ++i)
                    f = f.Derivative();
                return f;
            }
        }

        public static Function operator +(Function a, Function b)
        {
            return Addition.New(a, b);
        }

        public static Function operator +(double k, Function b)
        {
            return new Constant(k) + b;
        }

        public static Function operator +(Function a, double k)
        {
            return a + new Constant(k);
        }

        public static Function operator -(Function a, Function b)
        {
            return Difference.New(a, b);
        }

        public static Function operator -(double k, Function b)
        {
            return new Constant(k) - b;
        }

        public static Function operator -(Function a, double k)
        {
            return a - new Constant(k);
        }

        public static Function operator *(Function a, Function b)
        {
            return Multiplication.New(a, b);
        }

        public static Function operator *(double k, Function b)
        {
            return new Constant(k) * b;
        }

        public static Function operator *(Function a, double k)
        {
            return a * new Constant(k);
        }

        public static Function operator /(Function a, Function b)
        {
            return Division.New(a, b);
        }

        public static Function operator /(double k, Function b)
        {
            return new Constant(k) / b;
        }

        public static Function operator /(Function a, double k)
        {
            return a / new Constant(k);
        }
        /// <summary>
        /// Composition operator
        /// </summary>
        /// <returns>Composition.New(a, b)</returns>
        public static Function operator %(Function a, Function b)
        {
            return Composition.New(a, b);
        }
    }
}
