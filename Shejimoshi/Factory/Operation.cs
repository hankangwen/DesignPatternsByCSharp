using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Factory
{
    class Operation
    {
        private double numA = 0;
        private double numB = 0;

        public double NumA {
            get { return numA; }
            set { numA = value; }
        }
        public double NumB {
            get { return numB; }
            set { numB = value; }
        }

        public virtual double GetResult() {
            double result = 0d;
            return result;
        }
    }
}
