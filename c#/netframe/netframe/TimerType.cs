using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class TimerType : IAsyncType
    {
        private int _timerType = 0;
        public int GetType()
        {
            return _timerType;
        }
    }
}
