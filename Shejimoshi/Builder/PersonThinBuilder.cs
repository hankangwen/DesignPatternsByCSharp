using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Builder
{
    class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(string draw, string pen):base(draw, pen) { }

        public override void BuildHead()
        {
            Console.WriteLine("head");
        }

        public override void BuildBody()
        {
            Console.WriteLine("body");
        }

        public override void BuildArmLeft()
        {
            Console.WriteLine("BuildArmLeft");
        }

        public override void BuildArmRight()
        {
            Console.WriteLine("BuildArmRight");
        }
        
        public override void BuildLegLeft()
        {
            Console.WriteLine("BuildLegLeft");
        }

        public override void BuildLegRight()
        {
            Console.WriteLine("BuildLegRight");
        }
    }
}
