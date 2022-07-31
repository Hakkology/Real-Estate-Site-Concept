using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.EmlakSitesi
{
    internal class Metinler
    {
        public static void YanlışGiriş()
        {
            Console.WriteLine("Yanlış rakam girdiniz. Sizi girişe yönlendiriyoruz...");
        }
        public static void BaşaDönme()
        {
            Console.WriteLine("Sizi girişe yönlendiriyoruz...");
        }
        public static void KiralıkSatılık()
        {
            Console.Write("\nKiralık mı Satılık mı? \n" +
                                "(1) Satılık, (2) Kiralık: ");
        }
        public static void ArsaDaire()
        {
            Console.Write("\nArsa mı, daire mi? \n" +
                            "(1) Arsa, (2) Daire: ");
        }
        public static void ŞehirSeçim()
        {
            Console.Write("\nŞehir seçiniz \n" +
                            "(1) Ankara, (2) Bursa, (0) geri dönme: ");
        }
        public static void AnkaraSemtSeçim()
        {
            Console.Write("\nKonut aradığınız semti seçiniz \n" +
                            "(1) Beypazarı, (2) Çankaya, (3) Etimesgut (0) geri dönme: ");
        }
        public static void BursaSemtSeçim()
        {
            Console.Write("\nKonut aradığınız semti seçiniz \n" +
                            "(1) Nilüfer, (2) Osmangazi, (0) geri dönme: ");
        }
        public static void SıralamaMetin()
        {
            Console.Write("\nSeçeneklerinizi sıralamak ister misiniz?\n" +
                            "(1) m2ye göre, (2) fiyata göre, (3) tarihe göre: ");
        }
    }
}
