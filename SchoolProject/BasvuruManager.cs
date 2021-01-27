using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class BasvuruManager
    {
        public void GirisYapildi(ISchoolManager schoolManager,List<ILoggerService> loggerServices)
        {
            schoolManager.Add();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void GirisOnBilgilendirmesiYap(List<ISchoolManager> schools)
        {
            foreach (var school in schools)
            {
                school.Add();

            }

        }
    }
}
