using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Factory
{
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = NumA + NumB;   
            return result;
        }
    }
}
