using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class SmsService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandi");
        }
    }
}
