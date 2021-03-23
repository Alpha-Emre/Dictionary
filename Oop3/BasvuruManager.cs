using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager IkrediManager, List<ILoggerService> loggerServices)
        {
            IkrediManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                
                loggerService.log();
            }
            


        }

        public void KrediOnBilgilendirmesi(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
