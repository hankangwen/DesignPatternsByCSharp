using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Delegate
{
    class Boss : Subject
    {
        public event MYEventHandler Update;

        private string action;

        public string SubjectState {
            get { return action; }
            set { action = value; }
        }

        public void Notify()
        {
            Update();
        }


    }
}
