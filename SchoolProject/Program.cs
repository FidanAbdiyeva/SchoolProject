using System;
using System.Collections.Generic;

namespace SchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();

            DataBaseLoggerService dataBaseLoggerService = new DataBaseLoggerService();
            MailSendService mailSendService = new MailSendService();
            SmsService smsService = new SmsService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.GirisYapildi(studentManager, new List<ILoggerService> { new DataBaseLoggerService(), new SmsService(), new MailSendService() });

            List<ISchoolManager> schools = new List<ISchoolManager>() { studentManager};
            //basvuruManager.GirisOnBilgilendirmesiYap(schools);
        }
    }
}
