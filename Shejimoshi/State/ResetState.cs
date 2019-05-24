using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.State
{
    class ResetState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("current time {0} go home", work.Hour);
        }
    }
}
