using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.LightStateMoshi
{
    /// <summary>
    /// 抽象的电灯状态类，相当于State类
    /// </summary>
    public abstract class LightState
    {
        public abstract void PressSwitch(LightContext light);
    }
}
