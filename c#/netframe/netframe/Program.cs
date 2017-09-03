using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    class Program
    {
        public static void TestSyncClient()
        {
            SyncClient _syncClient = new SyncClient();

            _syncClient.Connect("127.0.0.1", 6688);
            _syncClient.Disconnect();
            _syncClient.Read();
            _syncClient.Write();

        }

        public static void TestAsyncClient()
        {
            AsyncClient _asyncClient = new AsyncClient();

            _asyncClient.Connect("127.0.0.1", 6688);
            _asyncClient.Disconnect();
            _asyncClient.Read();
            _asyncClient.Write();
        }

        static void Main(string[] args)
        {
            TestAsyncClient();
            TestSyncClient();
        }
    }
}
