using Shejimoshi.Agent;
using Shejimoshi.Decorator;
using Shejimoshi.Factory;
using Shejimoshi.FactoryFunction;
using Shejimoshi.Proxy;
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
            TestFactoryFunction();

        }

        /// <summary>
        /// 工厂模式方法
        /// </summary>
        static void TestFactoryFunction()
        {
            IFactory operFactory = new AddFactory();
            FactoryFunction.Operation oper = operFactory.CreateOperation();
            oper.NumA = 1;
            oper.NumB = 2;
            Console.WriteLine(oper.GetResult());
        }

        /// <summary>
        /// 代理模式
        /// </summary>
        static void TestProxy()
        {
            MyProxy myProxy = new MyProxy();
            myProxy.Request();
        }

        /// <summary>
        /// 代理模式
        /// </summary>
        static void TestAgent()
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";

            MyAgent daili = new MyAgent(jiaojiao);

            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();
        }

        /// <summary>
        /// 装饰模式
        /// </summary>
        static void TestDecorator()
        {
            Person xiaocai = new Person("xiaocai");
            Console.WriteLine("\n第一种装扮：");

            Sneakers sneaker = new Sneakers();
            BigTrouser bigTrouser = new BigTrouser();
            TShirts shirts = new TShirts();

            sneaker.Decorate(xiaocai);
            bigTrouser.Decorate(sneaker);
            shirts.Decorate(bigTrouser);
            shirts.Show();


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

                Factory.Operation oper = OperationFactory.createFactory(strOperation);
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
