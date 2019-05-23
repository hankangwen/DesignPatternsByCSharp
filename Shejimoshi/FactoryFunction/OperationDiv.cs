using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.FactoryFunction
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumB == 0)
                throw new Exception("除数不能为0");
            return NumA / NumB;
        }
    }
}
