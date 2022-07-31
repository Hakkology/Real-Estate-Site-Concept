using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.EmlakSitesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ödev Proje Hedef:
            //-List, const ve KDV ile beraber bir emlak sitesi oluşturup arsa, satılık ve kiralık daire objeleri oluşturma (Tamamlandı)
            //-Mümkünse interface kullanarak yeni gelen tüm sınıflara otomatik uygulama verme (Kısmen Tamamlandı)
            //-Her arsanın, satılık dairenin ve kiralık dairenin farklı bir sınıf altında bulunması ve bunların listelenmesi (Tamamlandı)
            //-Örnek olarak her sınıfa birkaç adet prototip ekleme, parametre olarak datetime kullanma, bool ile string yönetme (Tamamlandı)
            //-2 Constructor oluşturma, hem birim fiyattan endeksli KDV ile hesabı hem de toplu fiyattan KDV hesabı ile fiyat hesaplayan bir sistem oluşturma (Tamamlandı)
            //Constructor üzerinden liste adedinin otomatik güncellendiği bir yapı oluşturma (Tamamlandı)
            //-Listeler üzerinden parametre alma, gösterim sağlama, liste üyelerini belirli parametreler kapsamında sıralama/sort (Tamamlandı)
            //-Kullanıcıdan veri alarak yeni obje oluşturulması, bu objenin mevcut listelere eklenmesi ve istendiğinde gösterilmesi (Tamamlandı, save etmek mümkün değil)
            //-İleride yeni şehir eklenmesi durumuna karşın otomatik cevap veren bir yapı oluşturma enum? (Eksik)

            //List BeypazarıArsalar
            List<BeypazarıArsa> BeypazarıArsalar = new List<BeypazarıArsa>(BeypazarıArsa.Sayı());
            BeypazarıArsalar.Add(new BeypazarıArsa(150, 1200, "001-Name", "05360000001",new DateTime(2022, 07, 13), true));
            BeypazarıArsalar.Add(new BeypazarıArsa(240, 1400, "002-Name", "05360000002", new DateTime(2022, 07, 12), true));
            BeypazarıArsalar.Add(new BeypazarıArsa(190, 1800, "003-Name", "05360000003", new DateTime(2022, 07, 10), true));
            BeypazarıArsalar.Add(new BeypazarıArsa(190, "004-Name", "05360000004", 450000M, new DateTime(2022, 06, 12), true));
            BeypazarıArsalar.Add(new BeypazarıArsa(220, "005-Name", "05360000005", 380000M, new DateTime(2022, 06, 09), false));
            //List BeypazarıDairelerSatılık
            List<BeypazarıDaire> BeypazarıDaireler = new List<BeypazarıDaire>(BeypazarıDaire.Sayı());
            BeypazarıDaireler.Add(new BeypazarıDaire(80, 1600, "006-Name", "05360000006", new DateTime(2022, 07, 14), true));
            BeypazarıDaireler.Add(new BeypazarıDaire(140, 1300, "007-Name", "05360000007", new DateTime(2022, 07, 12), true));
            BeypazarıDaireler.Add(new BeypazarıDaire(110, 1900, "008-Name", "05360000008", new DateTime(2022, 07, 6),true));
            BeypazarıDaireler.Add(new BeypazarıDaire(120, "009-Name", "05360000009", 600000M, true, new DateTime(2022, 07, 13), true));
            BeypazarıDaireler.Add(new BeypazarıDaire(145, "010-Name", "05360000010", 720000M, true, new DateTime(2022, 07, 11), false));
            BeypazarıDaireler.Add(new BeypazarıDaire(95, "011-Name", "05360000011", 480000M, true, new DateTime(2022, 06, 13), true));
            //List BeypazarıDairelerKiralık
            BeypazarıDaireler.Add(new BeypazarıDaire(130, "012-Name", "05360000012", 5500M, false, new DateTime(2022, 07, 02), false));
            BeypazarıDaireler.Add(new BeypazarıDaire(75, "013-Name", "05360000013", 2500M, false, new DateTime(2022, 06, 19), true));
            BeypazarıDaireler.Add(new BeypazarıDaire(95, "014-Name", "05360000014", 4000M, false, new DateTime(2022, 07, 12), true));
            BeypazarıDaireler.Add(new BeypazarıDaire(80, "015-Name", "05360000015", 3000M, false, new DateTime(2022, 06, 15),false));
            //List ÇankayaArsalar
            List<ÇankayaArsa> ÇankayaArsalar = new List<ÇankayaArsa>(ÇankayaArsa.Sayı());
            ÇankayaArsalar.Add(new ÇankayaArsa(130, 1600, "016-Name", "05360000016", new DateTime(2022, 07, 2), true));
            ÇankayaArsalar.Add(new ÇankayaArsa(200, 2800, "017-Name", "05360000017", new DateTime(2022, 06, 28),true));
            ÇankayaArsalar.Add(new ÇankayaArsa(190, "018-Name", "05360000018", 750000M, new DateTime(2022, 07, 13),true));
            ÇankayaArsalar.Add(new ÇankayaArsa(80, "019-Name", "05360000019", 400000M, new DateTime(2022, 07, 11), false));
            //List ÇankayaDairelerSatılık
            List<ÇankayaDaire> ÇankayaDaireler = new List<ÇankayaDaire>(ÇankayaDaire.Sayı());
            ÇankayaDaireler.Add(new ÇankayaDaire(80, 2000, "020-Name", "05360000020", new DateTime(2022, 07, 13), true));
            ÇankayaDaireler.Add(new ÇankayaDaire(90, 2200, "021-Name", "05360000021", new DateTime(2022, 07, 11),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(105, 1700, "022-Name", "05360000022", new DateTime(2022, 07, 02),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(160, 2500, "023-Name", "05360000023", new DateTime(2022, 07, 11),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(200, 2200, "024-Name", "05360000024", new DateTime(2022, 06, 12),false));
            ÇankayaDaireler.Add(new ÇankayaDaire(150, "025-Name", "05360000025", 800000M,true, new DateTime(2022, 07, 09),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(140, "026-Name", "05360000026", 620000M,true, new DateTime(2022, 07, 13),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(75, "027-Name", "05360000027", 500000M,true, new DateTime(2022, 07, 06), false));
            ÇankayaDaireler.Add(new ÇankayaDaire(85, "028-Name", "05360000028", 460000M,true, new DateTime(2022, 07, 09),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(140, "029-Name", "05360000029", 740000M,true, new DateTime(2022, 07, 02),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(200, "030-Name", "05360000030", 1000000M,true, new DateTime(2022, 06, 29),false));
            //List ÇankayaDairelerKiralık
            ÇankayaDaireler.Add(new ÇankayaDaire(130, "031-Name", "05360000031", 4000M, false, new DateTime(2022, 07, 13),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(120, "032-Name", "05360000032", 5500M, false, new DateTime(2022, 07, 09),false));
            ÇankayaDaireler.Add(new ÇankayaDaire(80, "033-Name", "05360000033", 3500M, false, new DateTime(2022, 07, 08),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(190, "034-Name", "05360000034", 7000M, false, new DateTime(2022, 07, 03),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(85, "035-Name", "05360000035", 2500M, false, new DateTime(2022, 07, 1),true));
            ÇankayaDaireler.Add(new ÇankayaDaire(80, "036-Name", "05360000036", 2200M, false, new DateTime(2022, 06, 26),false));
            //List EtimesgutArsa
            List<EtimesgutArsa> EtimesgutArsalar = new List<EtimesgutArsa>(EtimesgutArsa.Sayı());
            EtimesgutArsalar.Add(new EtimesgutArsa(150, 2500, "037-Name", "05360000037", new DateTime(2022, 07, 13),true));
            EtimesgutArsalar.Add(new EtimesgutArsa(400, 1500, "038-Name", "05360000038", new DateTime(2022, 07, 09),true));
            EtimesgutArsalar.Add(new EtimesgutArsa(130, "039-Name", "05360000039", 350000M, new DateTime(2022, 07, 02),true));
            EtimesgutArsalar.Add(new EtimesgutArsa(230, "040-Name", "05360000040", 900000M, new DateTime(2022, 06, 22),false));
            //List EtimesgutDaireSatılık
            List<EtimesgutDaire> EtimesgutDaireler = new List<EtimesgutDaire>(EtimesgutDaire.Sayı());
            EtimesgutDaireler.Add(new EtimesgutDaire(65, 1300, "041-Name", "05360000041", new DateTime(2022, 07, 13),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(105, 1600, "042-Name", "05360000042", new DateTime(2022, 07, 09),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(80, 2000, "043-Name", "05360000043", new DateTime(2022, 07, 11),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(100, "044-Name", "05360000044", 550000M, true, new DateTime(2022, 07, 16),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(90, "045-Name", "05360000045", 230000M, true, new DateTime(2022, 07, 10),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(150, "046-Name", "05360000046", 760000M, true, new DateTime(2022, 05, 25),false));
            EtimesgutDaireler.Add(new EtimesgutDaire(135, "047-Name", "05360000047", 555000M, true, new DateTime(2022, 06, 13),true));
            //List EtimesgutDaireKiralık
            EtimesgutDaireler.Add(new EtimesgutDaire(180, "048-Name", "05360000048", 9500M, false, new DateTime(2022, 07, 13),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(120, "049-Name", "05360000049", 4500M, false, new DateTime(2022, 07, 12),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(65, "050-Name", "05360000050", 1500M, false, new DateTime(2022, 07, 06),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(90, "052-Name", "05360000052", 3500M, false, new DateTime(2022, 06, 15),true));
            EtimesgutDaireler.Add(new EtimesgutDaire(95, "053-Name", "05360000053", 2800M, false, new DateTime(2022, 06, 11),true));
            //List NilüferArsa
            List<NilüferArsa> NilüferArsalar = new List<NilüferArsa>(NilüferArsa.Sayı());
            NilüferArsalar.Add(new NilüferArsa(250, 2300, "037-Name", "05360000037", new DateTime(2022, 07, 13),true));
            NilüferArsalar.Add(new NilüferArsa(220, 2200, "038-Name", "05360000038", new DateTime(2022, 06, 09),true));
            NilüferArsalar.Add(new NilüferArsa(160, "039-Name", "05360000039", 550000M, new DateTime(2022, 06, 02),true));
            NilüferArsalar.Add(new NilüferArsa(340, "040-Name", "05360000040", 1115000M, new DateTime(2022, 05, 12),false));
            //List NilüferDaireSatılık
            List<NilüferDaire> NilüferDaireler = new List<NilüferDaire>(NilüferDaire.Sayı());
            NilüferDaireler.Add(new NilüferDaire(120, 2200, "041-Name", "05360000041", new DateTime(2022, 07, 03),true));
            NilüferDaireler.Add(new NilüferDaire(140, 2100, "042-Name", "05360000042", new DateTime(2022, 05, 13),true));
            NilüferDaireler.Add(new NilüferDaire(115, 1600, "043-Name", "05360000043", new DateTime(2022, 06, 16),true));
            NilüferDaireler.Add(new NilüferDaire(130, "044-Name", "05360000044", 680000M, true, new DateTime(2022, 07, 15), true));
            NilüferDaireler.Add(new NilüferDaire(125, "045-Name", "05360000045", 750000M, true, new DateTime(2022, 05, 21), true));
            NilüferDaireler.Add(new NilüferDaire(75, "046-Name", "05360000046", 220000M, true, new DateTime(2022, 04, 19), false));
            NilüferDaireler.Add(new NilüferDaire(145, "047-Name", "05360000047", 900000M, true, new DateTime(2022, 06, 13), true));
            //List NilüferDaireKiralık
            NilüferDaireler.Add(new NilüferDaire(115, "048-Name", "05360000048", 6000M, false, new DateTime(2022, 05, 09), true));
            NilüferDaireler.Add(new NilüferDaire(120, "049-Name", "05360000049", 4500M, false, new DateTime(2022, 06, 11), true));
            NilüferDaireler.Add(new NilüferDaire(105, "050-Name", "05360000050", 3500M, false, new DateTime(2022, 07, 13), true));
            NilüferDaireler.Add(new NilüferDaire(90, "051-Name", "05360000051", 3200M, false, new DateTime(2022, 06, 15), true));
            NilüferDaireler.Add(new NilüferDaire(165, "052-Name", "05360000052", 12000M, false, new DateTime(2022, 05, 25), false));
            NilüferDaireler.Add(new NilüferDaire(180, "053-Name", "05360000053", 11500M, false, new DateTime(2022, 07, 13), true));
            NilüferDaireler.Add(new NilüferDaire(190, "054-Name", "05360000054", 9000M, false, new DateTime(2022, 06, 18), true));
            NilüferDaireler.Add(new NilüferDaire(240, "055-Name", "05360000055", 14000M, false, new DateTime(2022, 05, 15), true));
            //List OsmangaziArsa
            List<OsmangaziArsa> OsmangaziArsalar = new List<OsmangaziArsa>(OsmangaziArsa.Sayı());
            OsmangaziArsalar.Add(new OsmangaziArsa(215, 2500, "056-Name", "05360000056", new DateTime(2022, 07, 13), true));
            OsmangaziArsalar.Add(new OsmangaziArsa(340, 1800, "057-Name", "05360000057", new DateTime(2022, 07, 5), true));
            OsmangaziArsalar.Add(new OsmangaziArsa(320, 1500, "058-Name", "05360000058", new DateTime(2022, 06, 25), true));
            OsmangaziArsalar.Add(new OsmangaziArsa(130, "059-Name", "05360000059", 520000M, new DateTime(2022, 06, 22), true));
            OsmangaziArsalar.Add(new OsmangaziArsa(320, "060-Name", "05360000060", 900000M, new DateTime(2022, 05, 29), false));
            OsmangaziArsalar.Add(new OsmangaziArsa(290, "061-Name", "05360000061", 899000M, new DateTime(2022, 02, 22), false));
            //List OsmangaziDaireSatılık
            List<OsmangaziDaire> OsmangaziDaireler = new List<OsmangaziDaire>(OsmangaziDaire.Sayı());
            OsmangaziDaireler.Add(new OsmangaziDaire(105, 1200, "062-Name", "05360000062", new DateTime(2022, 07, 14), true));
            OsmangaziDaireler.Add(new OsmangaziDaire(85, "063-Name", "05360000063", 450000M, true, new DateTime(2022, 07, 3), true));
            OsmangaziDaireler.Add(new OsmangaziDaire(90, "064-Name", "05360000064", 350000M, true, new DateTime(2022, 06, 13), true));
            //List OsmangaziDaireKiralık
            OsmangaziDaireler.Add(new OsmangaziDaire(100, "065-Name", "05360000065", 3500M, false, new DateTime(2022, 07, 9), true));
            OsmangaziDaireler.Add(new OsmangaziDaire(80, "066-Name", "05360000066", 2000M, false, new DateTime(2022, 05, 5), false));
            OsmangaziDaireler.Add(new OsmangaziDaire(75, "067-Name", "05360000067", 1800M, false, new DateTime(2022, 05, 27), true));

            //Programgiriş
            int giriş1;
            int giriş2;
            int giriş3;
            int giriş4;
            int giriş5;
            int giriş6 = 0;
            bool devam = true;
            decimal Alan = 0;
            string MalSahibi ="";
            string TelefonNo="";
            decimal Fiyat=0;

            Console.WriteLine("Vektörel Emlak sitemize hoşgeldiniz.Hayalinizdeki eve sahip olmak için doğru yerdesiniz.");

            while (devam)
            {
                try
                {
                    Console.Write("İlanlara bakmak için (1), ilan açmak için (2), siteden çıkmak için (0) a basınız:");
                    giriş1 = Convert.ToInt32(Console.ReadLine());
                    if (giriş1 == 1)
                    {
                        Metinler.ŞehirSeçim();
                        giriş2 = Convert.ToInt32(Console.ReadLine());
                        if (giriş2 == 1)
                        {
                            Metinler.AnkaraSemtSeçim();
                            giriş3 = Convert.ToInt32(Console.ReadLine());
                            if (giriş3 == 1)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    BeypazarıArsa.TopluArsaGösterim(BeypazarıArsalar);
                                    BeypazarıArsa.TopluArsaSıralama(BeypazarıArsalar, giriş6);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        BeypazarıDaire.TopluSatılıkDaireGösterim(BeypazarıDaireler);
                                        BeypazarıDaire.TopluSatılıkDaireSıralama(BeypazarıDaireler, giriş6);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        BeypazarıDaire.TopluKiralıkDaireGösterim(BeypazarıDaireler);
                                        BeypazarıDaire.TopluKiralıkDaireSıralama(BeypazarıDaireler, giriş6);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else if (giriş3 == 2)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    ÇankayaArsa.TopluArsaGösterim(ÇankayaArsalar);
                                    ÇankayaArsa.TopluArsaSıralama(ÇankayaArsalar, giriş6);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        ÇankayaDaire.TopluSatılıkDaireGösterim(ÇankayaDaireler);
                                        ÇankayaDaire.TopluSatılıkDaireSıralama(ÇankayaDaireler, giriş6);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        ÇankayaDaire.TopluKiralıkDaireGösterim(ÇankayaDaireler);
                                        ÇankayaDaire.TopluKiralıkDaireSıralama(ÇankayaDaireler, giriş6);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else if (giriş3 == 3)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    EtimesgutArsa.TopluArsaGösterim(EtimesgutArsalar);
                                    EtimesgutArsa.TopluArsaSıralama(EtimesgutArsalar, giriş6);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        EtimesgutDaire.TopluSatılıkDaireGösterim(EtimesgutDaireler);
                                        EtimesgutDaire.TopluSatılıkDaireSıralama(EtimesgutDaireler, giriş6);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        EtimesgutDaire.TopluKiralıkDaireGösterim(EtimesgutDaireler);
                                        EtimesgutDaire.TopluKiralıkDaireSıralama(EtimesgutDaireler, giriş6);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else if (giriş3 == 0)
                            { Metinler.BaşaDönme(); }
                            else
                            { Metinler.YanlışGiriş(); }
                        }
                        else if (giriş2 == 2)
                        {
                            Metinler.BursaSemtSeçim();
                            giriş3 = Convert.ToInt32(Console.ReadLine());
                            if (giriş3 == 1)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    NilüferArsa.TopluArsaGösterim(NilüferArsalar);
                                    NilüferArsa.TopluArsaSıralama(NilüferArsalar, giriş6);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        NilüferDaire.TopluSatılıkDaireGösterim(NilüferDaireler);
                                        NilüferDaire.TopluSatılıkDaireSıralama(NilüferDaireler, giriş6);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        NilüferDaire.TopluKiralıkDaireGösterim(NilüferDaireler);
                                        NilüferDaire.TopluKiralıkDaireSıralama(NilüferDaireler, giriş6);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else if (giriş3 == 2)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    OsmangaziArsa.TopluArsaGösterim(OsmangaziArsalar);
                                    OsmangaziArsa.TopluArsaSıralama(OsmangaziArsalar, giriş6);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        OsmangaziDaire.TopluSatılıkDaireGösterim(OsmangaziDaireler);
                                        OsmangaziDaire.TopluSatılıkDaireSıralama(OsmangaziDaireler, giriş6);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        OsmangaziDaire.TopluKiralıkDaireGösterim(OsmangaziDaireler);
                                        OsmangaziDaire.TopluKiralıkDaireSıralama(OsmangaziDaireler, giriş6);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else
                            { Metinler.YanlışGiriş(); }
                        }
                        else if (giriş2 == 0)
                        { Metinler.BaşaDönme(); }
                        else
                        { Metinler.YanlışGiriş(); }
                    }
                    else if (giriş1 == 2)
                    {
                        Metinler.ŞehirSeçim();
                        giriş2 = Convert.ToInt32(Console.ReadLine());
                        if (giriş2 == 1)
                        {
                            Metinler.AnkaraSemtSeçim();
                            giriş3 = Convert.ToInt32(Console.ReadLine());
                            if (giriş3 == 1)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    BeypazarıArsa.VeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, BeypazarıArsalar);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        BeypazarıDaire.SatılıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, BeypazarıDaireler);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        BeypazarıDaire.KiralıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, BeypazarıDaireler);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                {

                                }
                            }
                            else if (giriş3 == 2)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    ÇankayaArsa.VeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, ÇankayaArsalar);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        ÇankayaDaire.SatılıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, ÇankayaDaireler);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        ÇankayaDaire.KiralıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, ÇankayaDaireler);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else if (giriş3 == 3)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    EtimesgutArsa.VeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, EtimesgutArsalar);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        EtimesgutDaire.SatılıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, EtimesgutDaireler);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        EtimesgutDaire.KiralıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, EtimesgutDaireler);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else
                            { Metinler.YanlışGiriş(); }
                        }
                        else if (giriş2 == 2)
                        {
                            Metinler.BursaSemtSeçim();
                            giriş3 = Convert.ToInt32(Console.ReadLine());
                            if (giriş3 == 1)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    NilüferArsa.VeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, NilüferArsalar);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        NilüferDaire.SatılıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, NilüferDaireler);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        NilüferDaire.KiralıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, NilüferDaireler);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else if (giriş3 == 2)
                            {
                                Metinler.ArsaDaire();
                                giriş4 = Convert.ToInt32(Console.ReadLine());
                                if (giriş4 == 1)
                                {
                                    OsmangaziArsa.VeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, OsmangaziArsalar);
                                }
                                else if (giriş4 == 2)
                                {
                                    Metinler.KiralıkSatılık();
                                    giriş5 = Convert.ToInt32(Console.ReadLine());
                                    if (giriş5 == 1)
                                    {
                                        OsmangaziDaire.SatılıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, OsmangaziDaireler);
                                    }
                                    else if (giriş5 == 2)
                                    {
                                        OsmangaziDaire.KiralıkDaireVeriEkleme(Alan, MalSahibi, TelefonNo, Fiyat, OsmangaziDaireler);
                                    }
                                    else
                                    { Metinler.YanlışGiriş(); }
                                }
                                else
                                { Metinler.YanlışGiriş(); }
                            }
                            else
                            { Metinler.YanlışGiriş(); }
                        }
                        else if (giriş2 == 0)
                        { Metinler.BaşaDönme();}
                        else
                        { Metinler.YanlışGiriş(); }
                    }
                    else if (giriş1 == 0)
                    {
                        Console.WriteLine("Yine bekleriz.");
                        devam = false;
                    }
                    else
                    { Metinler.YanlışGiriş(); }
                    Console.ReadLine();
                }
                catch (Exception)
                { Metinler.YanlışGiriş(); }
            }
        }
    }
}
