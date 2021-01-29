using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService> { new FileLoggerService() , new SmsLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };


        }
    }
}
