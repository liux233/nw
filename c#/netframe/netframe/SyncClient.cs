using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class SyncClient : IClient
    {
        public int Connect(string ip, int port)
        {
            Console.WriteLine("syncclient connect {0}:{1}", ip, port);

            return 0;
        }

        public int Disconnect()
        {
            Console.WriteLine("syncclient disconnect");

            return 0;
        }

        public int Read()
        {
            Console.WriteLine("syncclient read");

            return 0;
        }

        public int Write()
        {
            Console.WriteLine("syncclient write");

            return 0;
        }
    }
}
