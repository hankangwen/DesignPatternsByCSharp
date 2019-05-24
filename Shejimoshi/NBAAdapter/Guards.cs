using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.NBAAdapter
{
    class Guards : Player
    {
        public Guards(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine("guards {0} attack", name);
        }

        public override void Defence()
        {
            Console.WriteLine("guards {0} defence", name);
        }
    }
}
