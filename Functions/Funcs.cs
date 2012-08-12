using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    public static class Funcs
    {
        /// <summary>
        /// f(x) = x ^ n
        /// </summary>
        /// <param name="n">n >= 0</param>
        /// <returns></returns>
        public static Function PowerFunction(int n)
        {
            return PowerFunction(Id, n);
        }
        /// <summary>
        /// f(x) = g(x) ^ n
        /// </summary>
        /// <param name="g"></param>
        /// <param name="n">n >= 0</param>
        /// <returns></returns>
        public static Function PowerFunction(Function g, int n)
        {
            if (n == 0)
                return Zero + 1;
            var f = g;
            for (int i = 1; i < n; ++i)
                f *= g;
            return f;
        }
        /// <summary>
        /// Fa(x) = 0 if x less than 0, and 1 - e^(-a*x) otherwise;
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Function NormalDistribition(double a = 1)
        {
            return Iplus * (1 - (Exp % (-a * Id)));
        }

        public static Function UniformDistribution(double a, double b)
        {
            return new IntervalFunction(a, b) * ((Id - a) / (b - a)) + new IntervalFunction(b, double.PositiveInfinity);
        }

        public static double Integrate(this Function f, double a, double b)
        {
            return Integrate(f, a, b, (b - a) * 0.00001);
        }

        public static double Integrate(this Function f, double a, double b, double delta)
        {
            if (Math.Sign(delta) != Math.Sign(b - a))
                delta *= -1;
            double sum = 0;
            int i = 0;
            for (double x = a; x < b; x += delta)
            {
                if (x + delta > b)
                {
                    sum += (b - x) * f.Calc(x);
                    break;
                }
                sum += delta * f.Calc(x);
                ++i;
            }
            return sum;
        }

        public static double SimpsonIntegrate(this Function f, double a, double b)
        {
            return SimpsonIntegrate(f, a, b, (b - a) * 0.00001);
        }

        public static double SimpsonIntegrate(this Function f, double a, double b, double delta)
        {
            if (Math.Sign(delta) != Math.Sign(b - a))
                delta *= -1;
            int n = (int) ((b - a) / delta);
            double h = (b - a) / n;
            double sum = 0;
            sum = f.Calc(a);
            for (int i = 1; i <= n; i += 2)
            {
                double x = a + h * i;
                sum += 4 * f.Calc(x);
            }
            for (int i = 2; i <= n - 1; i += 2)
            {
                double x = a + h * i;
                sum += 2 * f.Calc(x);
            }
            sum += f.Calc(b);
            /*int i = 0;
            for (double x = a; x < b; x += delta)
            {
                if (x + delta > b)
                {
                    delta = b - a;
                }
                sum += delta * (f.Calc(x) + 4 * f.Calc((2 * x + delta) / 2) + f.Calc(x + delta));
                ++i;
            }
            sum /= 6;*/
            return h * sum / 3;
        }
        /// <summary>
        /// Interval from 0 to +Infinity
        /// </summary>
        public static readonly Function Iplus = new IntervalFunction(0, double.PositiveInfinity);
        /// <summary>
        /// Interval from -Infinity to 0
        /// </summary>
        public static readonly Function Iminus = new IntervalFunction(double.NegativeInfinity, 0);

        public static readonly Function Id   = new Identity();

        public static readonly Function Exp  = new Exponenta();

        public static readonly Function Ln   = new Logarithm();

        public static readonly Function Zero = new Constant(0);

        public static readonly Function Sin  = new Sinus();
 
        public static readonly Function Cos  = new Cosinus();

        public static readonly Function Tan  = Sin / Cos;

        public static readonly Function Ctg  = Cos / Sin;

        public static readonly Function Sh   = (Exp - 1 / Exp) / 2;

        public static readonly Function Ch   = (Exp + 1 / Exp) / 2;

        public static readonly Function Tgh  = Sh / Ch;

        public static readonly Function Cth  = Sh / Ch;

        public static readonly Function Sign = Iplus - Iminus;

        public static readonly Function Abs  = Sign * Id;
    }
}
