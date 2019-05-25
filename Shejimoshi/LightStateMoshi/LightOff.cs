using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.LightStateMoshi
{
    /// <summary>
    /// 具体状态类，关
    /// </summary>
    class LightOff : LightState
    {
        public override void PressSwitch(LightContext light)
        {
            Console.WriteLine("turn on the light");

            light.State = new LightOn();
        }
    }
}
