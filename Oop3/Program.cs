using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager taksitKredimanager = new TaksitKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {new DatabaseLoggerService(), new SmsLoggerService()};        

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager,loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager, konutKrediManager, taksitKredimanager };

            //basvuruManager.KrediOnBilgilendirmesi(krediler);




        }
    }
}
