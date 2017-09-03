using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class TimerHandler : IAsyncEventHandler
    {
        public void EventHandle()
        {
            Console.WriteLine("handle timer event");
        }
    }
}
