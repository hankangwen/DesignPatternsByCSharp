using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Builder
{
    abstract class PersonBuilder
    {
        protected string draw;
        protected string pen;

        public PersonBuilder(string draw, string pen)
        {
            this.draw = draw;
            this.pen = pen;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();
    }
}
