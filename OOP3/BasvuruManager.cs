using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager kredimanager , List<ILoggerService> loggerService)
        {
            kredimanager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> Krediler)
        {
            foreach (var kredi in Krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
