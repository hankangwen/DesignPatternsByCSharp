using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.NBAAdapter
{
    class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("foward {0} jinggong", name);
        }

        public override void Defence()
        {
            Console.WriteLine("foward {0} fangshou", name);
        }
    }
}
