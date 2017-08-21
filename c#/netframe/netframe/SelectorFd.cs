using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class SelectorFd : IAsyncFd
    {
        private int _selectorFd = 3;
        public int GetFd()
        {
            Console.WriteLine("get selector fd");
            return _selectorFd;
        }
    }
}
