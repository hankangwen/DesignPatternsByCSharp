using Shejimoshi.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }

        /// <summary>
        /// 简单工厂模式
        /// </summary>
        static void TestFactory() {
            try
            {
                Console.WriteLine("A:");
                string strNumA = Console.ReadLine();

                Console.WriteLine("Operation:");
                string strOperation = Console.ReadLine();

                Console.WriteLine("B:");
                string strNumB = Console.ReadLine();

                Operation oper = OperationFactory.createFactory(strOperation);
                oper.NumA = Convert.ToDouble(strNumA);
                oper.NumB = Convert.ToDouble(strNumB);
                Console.WriteLine(oper.GetResult());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
