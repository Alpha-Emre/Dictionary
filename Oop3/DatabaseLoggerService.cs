using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Veri tabanına logalndı.");
        }
    }
}
