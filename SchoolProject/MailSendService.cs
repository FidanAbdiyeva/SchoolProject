using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class MailSendService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Mail gonderildi");
        }
    }
}
