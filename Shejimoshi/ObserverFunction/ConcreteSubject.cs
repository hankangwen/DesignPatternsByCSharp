using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.ObserverFunction
{
    /// <summary>
    /// 具体通知者
    /// </summary>
    class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
