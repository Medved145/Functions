using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {

        static void Main(string[] args)
        {
            var from2toMinusInfinity = Funcs.Iminus % (Funcs.Id - 2);
            var from0to2 = from2toMinusInfinity * Funcs.Iplus;
            for (int i = -3; i < 4; ++i)
                Console.WriteLine("f({0}) = {1}", i, from0to2.Calc(i));
            Console.ReadLine();
        }
    }
}
