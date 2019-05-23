using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Decorator
{
    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Sneakers");
            base.Show();
        }
    }
}
