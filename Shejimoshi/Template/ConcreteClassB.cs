using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Template
{
    class ConcreteClassB : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("Boperation1");
        }

        public override void Operation2()
        {
            Console.WriteLine("Boperation2");
        }
    }
}
