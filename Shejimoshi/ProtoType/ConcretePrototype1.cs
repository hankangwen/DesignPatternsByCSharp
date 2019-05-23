using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.ProtoType
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) { }

        public override Prototype Clone()
        {
            // MemberwiseClone-创建当前对象的浅表副本
            return (Prototype)this.MemberwiseClone();
        }
    }
}
