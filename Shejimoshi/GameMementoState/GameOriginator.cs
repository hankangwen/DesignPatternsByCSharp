using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.GameMementoState
{
    class GameOriginator
    {
        private int vit;
        private int atk;
        private int def;

        public GameMemento SaveState()
        {
            return (new GameMemento(vit, atk, def));
        }

        public void RecoveryState(GameMemento memento)
        {
            this.vit = memento.Vitality;
            this.atk = memento.Attack;
            this.def = memento.Defense;
        }

        public void GetInitState()
        {
            vit = 100;
            atk = 100;
            def = 100;
        }

        public void Fight()
        {
            vit -= 90;
            atk -= 80;
            def -= 30;
        }

        public void StateDisplay()
        {
            Console.WriteLine("vit:{0}, atk:{1}, def:{2}", vit, atk, def);
        }
    }
}
