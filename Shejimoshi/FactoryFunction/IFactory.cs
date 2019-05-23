using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.FactoryFunction
{
    interface IFactory
    {
        Operation CreateOperation();
    }
}
