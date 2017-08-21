using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class AsyncPolling : IAsyncPolling
    {
        private EventContainer _eventContainer;
        public virtual void add(IAsyncFd asyncFd, IAsyncType asyncType, IAsyncEventHandler asyncEventHandler)
        {
            _eventContainer = new EventContainer(asyncFd, asyncType, asyncEventHandler);
            Console.WriteLine("asyncpolling add fd, type, eventhandler");
        }

        public virtual void run()
        {
            Console.WriteLine("asyncpolling run");
        }

        public virtual void stop()
        {
            Console.WriteLine("asyncpolling stop");
        }

        /*
         * void do()
         * {
         *      select();
         *      for(fd in wfds) this.writer.GeWriteable().Update(fd);
         *      rfds
         *      efds
         *      
         * }
         */
    }
}
