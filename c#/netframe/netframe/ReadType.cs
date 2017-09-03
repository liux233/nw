using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class ReadType : IAsyncType
    {
        private int _readType = 2;
        public int GetType()
        {
            return _readType;
        }
    }
}
