using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class FileLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
