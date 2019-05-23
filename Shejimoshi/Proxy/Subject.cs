using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Proxy
{
    /// <summary>
    /// Subject:定义RealSubject和Proxy的共用接口，这样就在任何使用
    /// RealSubject的地方都可以使用Proxy
    /// </summary>
    abstract class Subject
    {
        public abstract void Request();
    }
}
