using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.EmlakSitesi
{
    internal class EtimesgutArsa
    {
        string il = $"{Şehirler.Ankara}";
        string ilçe = $"{Ankaraİlçeler.Etimesgut}";
        const decimal endeks = 1.7M;
        const decimal KDV = 1.18M;
        static int EtimesgutArsaAdet = 0;
        bool Geçerli;
        public EtimesgutArsa(decimal alan, decimal birimfiyat, string malsahibi, string telefonno, DateTime tarih, bool geçerli)
        {
            Alan = alan;
            BirimFiyat = birimfiyat;
            MalSahibi = malsahibi;
            TelefonNo = telefonno;
            Tarih = tarih;
            Geçerli = geçerli;
            FiyatHesap();
            EtimesgutArsaAdet++;
        }
        public EtimesgutArsa(decimal alan, string malsahibi, string telefonno, decimal fiyat, DateTime tarih, bool geçerli)
        {
            Alan = alan;
            MalSahibi = malsahibi;
            TelefonNo = telefonno;
            AnaFiyat = fiyat;
            KDVFiyatHesap();
            Tarih = tarih;
            Geçerli = geçerli;
            EtimesgutArsaAdet++;
        }
        public decimal Alan { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal AnaFiyat { get; set; }
        public string MalSahibi { get; set; }
        public string TelefonNo { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public string Geçerlilik { get { return Geçerli ? "İlan Geçerlidir." : "İlan Geçersizdir."; } }
        public decimal FiyatHesap()
        { return Fiyat = Alan * BirimFiyat * endeks * 1.18M; }
        public decimal KDVFiyatHesap()
        { return Fiyat = AnaFiyat * KDV; }
        public string İlçe()
        { return ilçe; }
        public string İl()
        { return il; }
        public void MalGösterim()
        {
            Console.WriteLine($"{İl()} ilinde {İlçe()} ilçesinde, {Alan} m2 {Tip()}\n" +
            $"Fiyat: {Fiyat} TL\n" +
            $"Bu ilan {Tarih} tarihinde açılmıştır ve {(DateTime.Now - Tarih).Days} gündür sitemizdedir. {Geçerlilik}\n" +
            $"İletişim için; İsim: {MalSahibi}\n" +
            $"Telefon No: {TelefonNo}\n" +
            $"--------------------------");
        }
        public static void TopluArsaGösterim(List<EtimesgutArsa> Liste)
        {
            foreach (var item in Liste)
            {
                item.MalGösterim();
            }
        }
        public static void TopluArsaSıralama(List<EtimesgutArsa> Liste, int a)
        {
            Metinler.SıralamaMetin();
            Console.WriteLine("******************");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                List<EtimesgutArsa> YeniListe = Liste.OrderBy(o => o.Alan).ToList();
                EtimesgutArsa.TopluArsaGösterim(YeniListe);
            }
            else if (a == 2)
            {
                List<EtimesgutArsa> YeniListe = Liste.OrderBy(o => o.Fiyat).ToList();
                EtimesgutArsa.TopluArsaGösterim(YeniListe);
            }
            else if (a == 3)
            {
                List<EtimesgutArsa> YeniListe = Liste.OrderBy(o => o.Tarih).ToList();
                EtimesgutArsa.TopluArsaGösterim(YeniListe);
            }
            else
            {
                Console.WriteLine("Yanlış rakam girdiniz. Sizi girişe                       yönlendiriyoruz...");
            }
        }
        public static void VeriEkleme(decimal a, string b, string c, decimal d, List<EtimesgutArsa> Liste)
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
            Liste.Add(new EtimesgutArsa(a, b, c, d, DateTime.Now, true));
        }
        static public int Sayı()
        { return EtimesgutArsaAdet; }
        static public string Tip()
        { return "Arsa"; }
    }
}
