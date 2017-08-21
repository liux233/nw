using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public interface IClient
    {
        int Connect(string ip, int port);
        int Disconnect();
        int Read();
        int Write();
    }
}
