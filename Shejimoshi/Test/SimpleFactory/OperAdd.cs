﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.Test.SimpleFactory
{
    class OperAdd : OperBase
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
