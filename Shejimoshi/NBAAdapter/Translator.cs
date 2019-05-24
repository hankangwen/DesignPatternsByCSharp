using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.NBAAdapter
{
    class Translator : Player
    {
        private ForeignCenter wjzf = new ForeignCenter();

        public Translator(string name) : base(name) {
            wjzf.Name = name;
        }

        public override void Attack()
        {
            wjzf.Jingong();
        }

        public override void Defence()
        {
            wjzf.Fanshou();
        }
    }
}
