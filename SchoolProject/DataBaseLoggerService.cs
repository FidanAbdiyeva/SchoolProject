using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyalara logglandi");
        }
    }
}
