using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public interface IAsyncPolling
    {
        void add(IAsyncFd asyncFd, IAsyncType asyncType, IAsyncEventHandler asyncEventHandler);
        void run();
        void stop();
    }
}
