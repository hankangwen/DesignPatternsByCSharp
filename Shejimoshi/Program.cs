using Shejimoshi.Agent;
using Shejimoshi.Builder;
using Shejimoshi.Builder2;
using Shejimoshi.Decorator;
using Shejimoshi.Facade;
using Shejimoshi.Factory;
using Shejimoshi.FactoryFunction;
using Shejimoshi.ObserverFunction;
using Shejimoshi.ProtoType;
using Shejimoshi.ProtoType2;
using Shejimoshi.Proxy;
using Shejimoshi.Strategy;
using Shejimoshi.Template;
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
            TestObserver();

        }

        /// <summary>
        /// 观察者模式
        /// </summary>
        static void TestObserver()
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();
        }

        static void TestBuilder2()
        {
            Director director = new Director();
            MyBuilder b1 = new ConcreteBuilder1();
            MyBuilder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
        }

        /// <summary>
        /// 建造者模式
        /// </summary>
        static void TestBuilder()
        {
            PersonThinBuilder ptb = new PersonThinBuilder("draw", "pen");
            PersonDirector personDirector = new PersonDirector(ptb);
            personDirector.CreatePerson();

            PersonThinBuilder pfb = new PersonThinBuilder("draw", "pen");
            PersonDirector pdFat = new PersonDirector(pfb);
            pdFat.CreatePerson();

        }

        /// <summary>
        /// 外观模式
        /// </summary>
        static void TestFacede()
        {
            MyFacade facade = new MyFacade();

            facade.MethodA();
            facade.MethodB();

        }

        /// <summary>
        /// 模板方法模式
        /// </summary>
        static void TestTemplateMethod()
        {
            AbstractClass c;
            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();
        }

        /// <summary>
        /// 原型模式2
        /// </summary>
        static void TestProtoType2() {
            Resume a = new Resume("xiaowen");
            a.SetPersonalInfo("boy", "20");
            a.SetWorkExperience("2018-2019", "xxCompany");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2015-2016", "yyCompany");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("boy", "22");

            a.Display();
            b.Display();
            c.Display();
        }

        /// <summary>
        /// 原型模式
        /// </summary>
        static void TestProtoType()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 p2 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned:{0}", p2.Id);
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
