using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface lerde kendisini implemente eden classın referans numarasını tutabilir.
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            ıhtiyacKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            tasıtKrediManager.Hesapla();

            //Başvuru yapma simülasyonu
            ILoggerService datebaseloggerservice = new DatabaseLoggerService();
            ILoggerService fileloggerservice = new FileLoggerService();

            /*List<ILoggerService> loggerServices = new List<ILoggerService>() { datebaseloggerservice, fileloggerservice };*/ 

            BasvuruManager basvuruManager = new BasvuruManager();
            Console.WriteLine();
            basvuruManager.BasvuruYap(new EsnafKrediManager()/*alternatif instance*/, new List<ILoggerService>() { datebaseloggerservice, fileloggerservice });
            Console.WriteLine();

            //Kredi Seçimi simülasyon
            List<IKrediManager> kredis = new List<IKrediManager>() { ıhtiyacKrediManager, konutKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(kredis);

            Console.Read();
        }
    }
}
