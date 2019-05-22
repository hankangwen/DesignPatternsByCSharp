using Shejimoshi.Factory;
using Shejimoshi.Strategy;
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
            TestStrategy();

        }

        /// <summary>
        /// 策略模式
        /// </summary>
        static void TestStrategy() {
            Console.WriteLine("单价：");
            string price = Console.ReadLine();

            Console.WriteLine("数量：");
            string num = Console.ReadLine();

            Console.WriteLine("类型：");
            string cashType = Console.ReadLine();
            
            double totalPrices = 0d;
            CashContext csuper = new CashContext(cashType);
            totalPrices = csuper.GetResult(Convert.ToDouble(price) * Convert.ToDouble(num));
            Console.WriteLine(totalPrices);
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
