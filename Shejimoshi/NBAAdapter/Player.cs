 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.NBAAdapter
{
    abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defence();
    }
}
