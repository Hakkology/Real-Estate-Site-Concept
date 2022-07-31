using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.EmlakSitesi
{
    internal class EtimesgutDaire
    {
        string il = $"{Şehirler.Ankara}";
        string ilçe = $"{Ankaraİlçeler.Etimesgut}";
        const decimal endeks = 3.2M;
        const decimal KDV = 1.18M;
        static int EtimesgutDaireAdet = 0;
        bool Satınkira;
        bool Geçerli;
        public EtimesgutDaire(decimal alan, decimal birimfiyat, string malsahibi, string telefonno, DateTime tarih, bool geçerli)
        {
            Alan = alan;
            BirimFiyat = birimfiyat;
            MalSahibi = malsahibi;
            TelefonNo = telefonno;
            Satınkira = true;
            Tarih = tarih;
            Geçerli = geçerli;
            FiyatHesap();
            EtimesgutDaireAdet++;
        }
        public EtimesgutDaire(decimal alan, string malsahibi, string telefonno, decimal fiyat, bool satınkira, DateTime tarih, bool geçerli)
        {
            Alan = alan;
            MalSahibi = malsahibi;
            TelefonNo = telefonno;
            AnaFiyat = fiyat;
            KDVFiyatHesap();
            Satınkira = satınkira;
            Tarih = tarih;
            Geçerli = geçerli;
            EtimesgutDaireAdet++;
        }
        public decimal Alan { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal AnaFiyat { get; set; }
        public string MalSahibi { get; set; }
        public string TelefonNo { get; set; }
        public decimal Fiyat { get; set; }
        public string SatınKira { get { return Satınkira ? "Satılık" : "Kiralık"; } }
        public DateTime Tarih { get; set; }
        public string Geçerlilik { get { return Geçerli ? "İlan Geçerlidir." : "İlan Geçersizdir."; } }
        public decimal FiyatHesap()
        { return Fiyat = Alan * BirimFiyat * endeks * 1.5M * 1.18M; }
        public decimal KDVFiyatHesap()
        { return Fiyat = AnaFiyat * KDV; }
        public string İlçe()
        { return ilçe; }
        public string İl()
        { return il; }
        public void MalGösterim()
        {
            Console.WriteLine($"{İl()} ilinde {İlçe()} ilçesinde, {Alan} m2 {SatınKira} {Tip()}\n" +
            $"Fiyat: {Fiyat} TL\n" +
            $"Bu ilan {Tarih} tarihinde açılmıştır ve {(DateTime.Now - Tarih).Days} gündür sitemizdedir. {Geçerlilik}\n" +
            $"İletişim için; İsim: {MalSahibi}\n" +
            $"Telefon No: {TelefonNo}\n" +
            $"--------------------------");
        }
        public static void TopluKiralıkDaireGösterim(List<EtimesgutDaire> Liste)
        {
            foreach (var item in Liste)
            {
                if (item.SatınKira == "Kiralık")
                { item.MalGösterim(); }
                else
                { continue; }
            }
        }
        public static void TopluSatılıkDaireGösterim(List<EtimesgutDaire> Liste)
        {
            foreach (var item in Liste)
            {
                if (item.SatınKira == "Satılık")
                { item.MalGösterim(); }
                else
                { continue; }
            }
        }
        public static void TopluKiralıkDaireSıralama(List<EtimesgutDaire> Liste, int a)
        {
            Metinler.SıralamaMetin();
            Console.WriteLine("******************");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                List<EtimesgutDaire> YeniListe = Liste.OrderBy(o => o.Alan).ToList();
                EtimesgutDaire.TopluKiralıkDaireGösterim(YeniListe);
            }
            else if (a == 2)
            {
                List<EtimesgutDaire> YeniListe = Liste.OrderBy(o => o.Fiyat).ToList();
                EtimesgutDaire.TopluKiralıkDaireGösterim(YeniListe);
            }
            else if (a == 3)
            {
                List<EtimesgutDaire> YeniListe = Liste.OrderBy(o => o.Tarih).ToList();
                EtimesgutDaire.TopluKiralıkDaireGösterim(YeniListe);
            }
            else
            {
                Console.WriteLine("Yanlış rakam girdiniz. Sizi girişe                       yönlendiriyoruz...");
            }
        }
        public static void TopluSatılıkDaireSıralama(List<EtimesgutDaire> Liste, int a)
        {
            Metinler.SıralamaMetin();
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                List<EtimesgutDaire> YeniListe = Liste.OrderBy(o => o.Alan).ToList();
                EtimesgutDaire.TopluSatılıkDaireGösterim(YeniListe);
            }
            else if (a == 2)
            {
                List<EtimesgutDaire> YeniListe = Liste.OrderBy(o => o.Fiyat).ToList();
                EtimesgutDaire.TopluSatılıkDaireGösterim(YeniListe);
            }
            else if (a == 3)
            {
                List<EtimesgutDaire> YeniListe = Liste.OrderBy(o => o.Tarih).ToList();
                EtimesgutDaire.TopluSatılıkDaireGösterim(YeniListe);
            }
            else
            {
                Console.WriteLine("Yanlış rakam girdiniz. Sizi girişe                       yönlendiriyoruz...");
            }
        }
        public static void SatılıkDaireVeriEkleme(decimal a, string b, string c, decimal d, List<EtimesgutDaire> Liste)
        {
            Console.Write("Alan giriniz: ");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mal sahibi ismini giriniz: ");
            b = Console.ReadLine();
            do
            {
                Console.Write("Mal sahibinin telefon numarasını giriniz: ");
                c = Console.ReadLine();
            } while (c.Length != 10);
            do
            {
                Console.Write("Fiyat giriniz: ");
                d = Convert.ToDecimal(Console.ReadLine());
            } while (d > 10000000M);
            Liste.Add(new EtimesgutDaire(a, b, c, d, true, DateTime.Now, true));
        }
        public static void KiralıkDaireVeriEkleme(decimal a, string b, string c, decimal d, List<EtimesgutDaire> Liste)
        {
            Console.Write("Alan giriniz: ");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mal sahibi ismini giriniz: ");
            b = Console.ReadLine();
            do
            {
                Console.Write("Mal sahibinin telefon numarasını giriniz: ");
                c = Console.ReadLine();
            } while (c.Length != 10);
            do
            {
                Console.Write("Fiyat giriniz: ");
                d = Convert.ToDecimal(Console.ReadLine());
            } while (d > 10000000M);
            Liste.Add(new EtimesgutDaire(a, b, c, d, false, DateTime.Now, true));
        }
        static public int Sayı()
        { return EtimesgutDaireAdet; }
        static public string Tip()
        { return "Daire"; }
    }
}
