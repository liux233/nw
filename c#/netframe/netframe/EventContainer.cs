using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class EventContainer
    {
        private IAsyncFd _asyncFd;
        private IAsyncType _asyncType;
        private IAsyncEventHandler _asyncEventHandler;
        public EventContainer(IAsyncFd asyncFd, IAsyncType asyncType, IAsyncEventHandler asyncEventHandler)
        {
            this._asyncFd = asyncFd;
            this._asyncType = asyncType;
            this._asyncEventHandler = asyncEventHandler;
        }

    }
}
