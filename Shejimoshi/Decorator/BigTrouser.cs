using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Decorator
{
    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("BigTrouser");
            base.Show();
        }
    }
}
