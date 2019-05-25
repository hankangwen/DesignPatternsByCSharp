using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.StateMoShi
{
    class ConcreteStateB : State
    {
        /// <summary>
        /// 设置ConcreteStateB的下一个状态是ConcreteSateA
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(MyContext context)
        {
            Console.WriteLine("state B");
            context.State = new ConcreteStateA();
        }
    }
}
