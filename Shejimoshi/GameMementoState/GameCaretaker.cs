using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.GameMementoState
{
    class GameCaretaker
    {
        private GameMemento memento;

        public GameMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
