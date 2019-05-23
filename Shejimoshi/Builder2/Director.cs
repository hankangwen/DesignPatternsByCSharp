using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Builder2
{
    class Director
    {
        public void Construct(MyBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
