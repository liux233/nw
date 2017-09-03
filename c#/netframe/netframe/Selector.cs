using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class Selector : AsyncPolling
    {
        private EventContainer _eventContainer;
        public override void add(IAsyncFd asyncFd, IAsyncType asyncType, IAsyncEventHandler asyncEventHandler)
        {
            _eventContainer = new EventContainer(asyncFd, asyncType, asyncEventHandler);
            Console.WriteLine("selector add");
        }

        public override void run()
        {
            Console.WriteLine("selector run");
        }
        public override void stop()
        {
            Console.WriteLine("selector stop");
        }
    }
}
