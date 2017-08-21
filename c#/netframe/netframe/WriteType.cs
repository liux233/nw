using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class WriteType : IAsyncType
    {
        private int _writeType = 1;
        public int GetType()
        {
            return _writeType;
        }
    }
}
