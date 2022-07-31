using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.EmlakSitesi
{
    internal class BeypazarıArsa : IAnkaraBeypazarı
    {
        string il = $"{Şehirler.Ankara}";
        string ilçe = $"{Ankaraİlçeler.Beypazarı}";
        const decimal endeks = 1.7M;
        const decimal KDV = 1.18M;
        static int BeypazarıArsaAdet = 0;
        bool Geçerli;
        
        public BeypazarıArsa(decimal alan, decimal birimfiyat, string malsahibi, string telefonno, DateTime tarih, bool geçerli)
        {
            Alan = alan;
            BirimFiyat = birimfiyat;
            MalSahibi = malsahibi;
            TelefonNo = telefonno;
            Tarih = tarih;
            FiyatHesap();
            Geçerli = geçerli;
            BeypazarıArsaAdet++;
        }
        public BeypazarıArsa(decimal alan, string malsahibi, string telefonno, decimal fiyat, DateTime tarih, bool geçerli)
        {
            Alan = alan;
            MalSahibi = malsahibi;
            TelefonNo = telefonno;
            AnaFiyat = fiyat;
            KDVFiyatHesap();
            Tarih = tarih;
            Geçerli = geçerli;
            BeypazarıArsaAdet++;
        }
        public decimal Alan { get; set; }
        public decimal BirimFiyat { get; set; }
        public string MalSahibi { get; set; }
        public decimal AnaFiyat { get; set; }
        public string TelefonNo { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public string Geçerlilik { get { return Geçerli ? "İlan Geçerlidir." : "İlan Geçersizdir."; } }

        public decimal FiyatHesap()
        {return Fiyat = Alan * BirimFiyat * endeks * 1.18M;}
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
        public static void TopluArsaGösterim(List<BeypazarıArsa> Liste)
        {
            foreach (var item in Liste)
            {
                item.MalGösterim();
            }
        }
        public static void TopluArsaSıralama(List<BeypazarıArsa> Liste, int a)
        {
            Metinler.SıralamaMetin();
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************");
            if (a==1)
            {
                List<BeypazarıArsa> YeniListe = Liste.OrderBy(o => o.Alan).ToList();
                BeypazarıArsa.TopluArsaGösterim(YeniListe);
            }
            else if (a==2)
            {
                List<BeypazarıArsa> YeniListe = Liste.OrderBy(o => o.Fiyat).ToList();
                BeypazarıArsa.TopluArsaGösterim(YeniListe);
            }
            else if (a==3)
            {
                List<BeypazarıArsa> YeniListe = Liste.OrderBy(o => o.Tarih).ToList();
                BeypazarıArsa.TopluArsaGösterim(YeniListe);
            }
            else
            {
                Console.WriteLine("Yanlış rakam girdiniz. Sizi girişe                       yönlendiriyoruz...");
            }
        }

        public static void VeriEkleme(decimal a, string b, string c, decimal d, List<BeypazarıArsa> Liste)
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
            Liste.Add(new BeypazarıArsa(a, b, c, d, DateTime.Now, true));
        }
        static public int Sayı()
        {return BeypazarıArsaAdet;}
        public string Tip()
        { return "Arsa"; }

    }
}
