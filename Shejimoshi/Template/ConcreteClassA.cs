using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Template
{
    class ConcreteClassA : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("Aoperation1");
        }

        public override void Operation2()
        {
            Console.WriteLine("Aoperation2");
        }
    }
}
