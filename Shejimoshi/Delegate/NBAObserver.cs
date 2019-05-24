using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Delegate
{
    class NBAObserver
    {
        private string name;
        private Subject sub;

        public NBAObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0} {1} close NBA", sub.SubjectState, name);
        }
    }
}
