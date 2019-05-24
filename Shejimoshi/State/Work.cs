using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.State
{
    class Work
    {
        private State currentState;
        private double hour;
        private bool finish = false;

        public Work()
        {
            currentState = new ForenoonState();
        }

        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State s)
        {
            currentState = s;
        }

        public void WriteProgram()
        {
            currentState.WriteProgram(this);
        }
    }
}
