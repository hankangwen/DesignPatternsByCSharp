using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Test.SimpleFactory
{
    class TestMyFactory
    {
        public static OperBase createFactory(string oper)
        {
            OperBase operClass = null;

            switch (oper)
            {
                case "+":

                default:
                    break;
            }

            return operClass;
        }

    }
}
