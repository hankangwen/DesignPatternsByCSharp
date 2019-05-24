using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.State
{
    class SleepingState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("curtime {0} cannot work, sleep", work.Hour);
        }
    }
}
