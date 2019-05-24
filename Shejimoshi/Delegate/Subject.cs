using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Delegate
{
    delegate void MYEventHandler();
    interface Subject
    {
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }
}
