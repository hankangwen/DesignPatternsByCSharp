using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Facade
{
    class MyFacade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        
        public MyFacade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("A");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("B");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
