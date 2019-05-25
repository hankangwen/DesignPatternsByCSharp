using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.LightStateMoshi
{
    /// <summary>
    /// 电灯类，对应模式中的Context类
    /// </summary>
    public class LightContext
    {
        private LightState state;

        public LightContext(LightState state)
        {
            this.state = state;
        }

        /// <summary>
        /// 按下电灯开关
        /// </summary>
        public void PressSwitch()
        {
            state.PressSwitch(this);
        }

        public LightState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
