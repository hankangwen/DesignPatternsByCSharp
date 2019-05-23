using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.ProtoType
{
    abstract class Prototype
    {
        private string id;

        public string Id
        {
            get { return id; }
        }

        public Prototype(string id)
        {
            this.id = id;
        }

        // 抽象类关键是要有这样一个Clone方法
        public abstract Prototype Clone();
    }
}
