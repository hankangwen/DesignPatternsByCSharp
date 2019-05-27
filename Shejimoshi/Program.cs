using Shejimoshi.AbstractFactory;
using Shejimoshi.Adapter;
using Shejimoshi.Agent;
using Shejimoshi.Builder;
using Shejimoshi.Builder2;
using Shejimoshi.CompositeMoshi;
using Shejimoshi.Decorator;
using Shejimoshi.Delegate;
using Shejimoshi.Facade;
using Shejimoshi.Factory;
using Shejimoshi.FactoryFunction;
using Shejimoshi.GameMementoState;
using Shejimoshi.LightStateMoshi;
using Shejimoshi.MementoState;
using Shejimoshi.NBAAdapter;
using Shejimoshi.ObserverFunction;
using Shejimoshi.ProtoType;
using Shejimoshi.ProtoType2;
using Shejimoshi.Proxy;
using Shejimoshi.State;
using Shejimoshi.StateMoShi;
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
            TestComposite();

        }

        /// <summary>
        /// 组合模式
        /// </summary>
        static void TestComposite()
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);

            Composite comp2 = new Composite("Composite XY");
            comp2.Add(new Leaf("Leaf XYA"));
            comp2.Add(new Leaf("Leaf XYB"));
            comp.Add(comp2);

            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
        }

        /// <summary>
        /// 测试游戏备忘录模式
        /// </summary>
        static void TestGameMementoState()
        {
            // 大战boss前
            GameOriginator role = new GameOriginator();
            role.GetInitState();
            role.StateDisplay();

            // 保存进度
            GameCaretaker stateAdmin = new GameCaretaker();
            stateAdmin.Memento = role.SaveState();

            // 损耗严重
            role.Fight();
            role.StateDisplay();

            //恢复备份
            role.RecoveryState(stateAdmin.Memento);
            role.StateDisplay();
        }

        /// <summary>
        /// 测试备忘录模式
        /// </summary>
        static void TestMementoState()
        {
            Originator o = new Originator();
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            o.Show();


            o.SetMemento(c.Memento);
            o.Show();
        }

        /// <summary>
        /// 状态模式--灯
        /// </summary>
        static void TestLightState()
        {
            LightContext context = new LightContext(new LightOff());

            context.PressSwitch();
            context.PressSwitch();
            context.PressSwitch();
            context.PressSwitch();
        }

        /// <summary>
        /// 状态模式
        /// </summary>
        static void TestStateMoshi()
        {
            // 设置Context的初始状态为ConcreteStateA
            MyContext context = new MyContext(new ConcreteStateA());

            // 不断地进行请求，同时更改状态
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }

        /// <summary>
        /// NBA适配器模式
        /// </summary>
        static void TestNBAAdapter()
        {
            Player b = new Forwards("badier");
            b.Attack();
            Player m = new Guards("maike");
            m.Attack();

            Player ym = new Center("yaoming");
            ym.Attack();
            ym.Defence();
        }

        /// <summary>
        /// 适配器模式
        /// </summary>
        static void TestAdapter()
        {
            Target target = new MyAdapter();
            target.Request();
        }

        /// <summary>
        /// 状态模式
        /// </summary>
        static void TestStatic()
        {
            Work emergencyProjects = new Work();
            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 17;

            emergencyProjects.TaskFinished = false;

            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();
        }

        /// <summary>
        /// 抽象工厂模式
        /// </summary>
        static void TestFactoryByDB()
        {
            User user = new User();
            Department dept = new Department();
            
            IUser iu = DataAccess.CreateUser();

            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(dept);
            id.GetDepartment(1);
        }

        #region test delegate
        delegate double CalEventHandler(double numA, double numB);
        static event CalEventHandler CalFunc;

        static void Testdelegate()
        {
            CalFunc += new CalEventHandler(Add);
            Console.WriteLine(CalFunc(3, 2));

            CalFunc += new CalEventHandler(Mul);
            Console.WriteLine(CalFunc(3, 2));
        }

        static double Add(double numA, double numB) {
            double result = numA + numB;
            return result;
        }
        static double Mul(double numA, double numB)
        {
            double result = numA * numB;
            return result;
        }
        #endregion

        /// <summary>
        /// 事件委托实现
        /// </summary>
        static void TestDelegate()
        {
            Boss huhansan = new Boss();

            StockObserver tongshi1 = new StockObserver("xiaohuang", huhansan);
            NBAObserver tongshi2 = new NBAObserver("xiaoming", huhansan);

            // 1.一个委托可以搭载多个方法，所有方法被依次唤起
            // 2.委托对象所搭载的方法并不需要属于同一个类
            huhansan.Update += new MYEventHandler(tongshi1.CloseStockmarket);
            huhansan.Update += new MYEventHandler(tongshi2.CloseNBADirectSeeding);

            huhansan.SubjectState = "come back";
            huhansan.Notify();
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
            FactoryFunction.IFactory operFactory = new AddFactory();
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
