using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.State
{
    class ForenoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if(work.Hour < 12)
            {
                Console.WriteLine("jinshengbaibei {0}time", work.Hour);
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}
