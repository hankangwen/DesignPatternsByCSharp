using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.GameMementoState
{
    class GameMemento
    {
        private int vit;
        private int atk;
        private int def;
        public GameMemento(int vit, int atk, int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }

        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }

        public int Attack
        {
            get { return vit; }
            set { vit = value; }
        }

        public int Defense
        {
            get { return def; }
            set { def = value; }
        }
    }
}
