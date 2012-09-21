using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingDelegates
{
    class BackgroundMessage
    {
        public static void Show(string message)
        {
            Console.WriteLine("({0})", message);
        }
    }
}
