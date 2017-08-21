using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netframe
{
    public class ConnectHandler : WriteHandler
    {
        public override void EventHandle()
        {
            Console.WriteLine("handle connect event");
        }
    }
}
