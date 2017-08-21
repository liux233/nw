using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class WriteHandler : IAsyncEventHandler
    {
        public virtual void EventHandle()
        {
            Console.WriteLine("handle write event");
        }
    }
}
