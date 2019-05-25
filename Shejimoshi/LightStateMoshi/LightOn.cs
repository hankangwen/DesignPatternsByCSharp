using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.LightStateMoshi
{
    /// <summary>
    ///  具体状态类, 开
    /// </summary>
    class LightOn : LightState
    {
        public override void PressSwitch(LightContext light)
        {
            Console.WriteLine("turn off the light");

            light.State = new LightOff();
        }
    }
}
