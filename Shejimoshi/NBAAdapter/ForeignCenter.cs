using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.NBAAdapter
{
    class ForeignCenter
    {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public void Jingong()
        {
            Console.WriteLine("外籍中锋 {0} Jingong", name);
        }

        public void Fanshou()
        {
            Console.WriteLine("外籍中锋 {0} Fanshou", name);
        }
    }
}
