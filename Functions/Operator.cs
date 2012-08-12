using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    public abstract class Operator : Function
    {
        protected Operator(Function a, Function b)
        {
            leftFunc = a;
            rightFunc = b;
        }

        protected readonly Function leftFunc;
        protected readonly Function rightFunc;
    }
}
