using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class AsyncClient : IClient
    {
        /*
         * AsyncClient ac = new AsyncClient(connectable, readable, writebale);
         * AsyncPolling ap = new Selector();
         * ap.add(new AsyncTypeWrite(), ac.GetFd(), ac.GetConnectable());
         * ap.add(new AsyncTypeRead(), ac.GetFd(), ac.GetReadable());
         * ap.add(new AsyncTypeWrite(), ac.GetFd(), ac.GetWriteable());
         * ap.run();
         */

        private WriteHandler _connectHandler = new ConnectHandler();
        public int Connect(string ip, int port)
        {
            _connectHandler.EventHandle();

            return 0;
        }

        public int Disconnect()
        {
            Console.WriteLine("async disconenct");

            return 0;
        }

        public ReadHandler _readHandler = new ReadHandler();
        public int Read()
        {
            _readHandler.EventHandle();

            return 0;
        }

        private WriteHandler _writeHandler = new WriteHandler();
        public int Write()
        {
            _writeHandler.EventHandle();

            return 0;
        }
    }
}
