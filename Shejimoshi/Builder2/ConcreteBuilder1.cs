using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Builder2
{
    class ConcreteBuilder1 : MyBuilder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("part A");
        }

        public override void BuildPartB()
        {
            product.Add("part B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
