using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.State
{
    class NoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if(work.Hour < 13)
            {
                Console.WriteLine("wufan kun {0}time", work.Hour);
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}
