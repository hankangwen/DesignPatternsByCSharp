using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Test.SimpleFactory
{
    class OperBase
    {
        private double numberA;
        private double numberB;

        public double NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }
        public double NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }

        public virtual double GetResult()
        {
            return 0;
        }
    }
}
