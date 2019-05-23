using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Template
{
    /// <summary>
    /// 模板
    /// </summary>
    abstract class AbstractClass
    {
        public abstract void Operation1();
        public abstract void Operation2();

        public void TemplateMethod()
        {
            Operation1();
            Operation2();
            Console.WriteLine("");
        }
    }
}
