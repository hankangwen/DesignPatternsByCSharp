using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.NBAAdapter
{
    class Center : Player
    {
        public Center(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine("center {0} attack", name);
        }

        public override void Defence()
        {
            Console.WriteLine("center {0} defence", name);
        }
    }
}
