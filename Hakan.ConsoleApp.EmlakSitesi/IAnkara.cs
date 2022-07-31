using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.EmlakSitesi
{
    enum Ankaraİlçeler
    {
        Beypazarı,
        Çankaya,
        Etimesgut
    }
    public interface IAnkara:IŞehirler
    {
        decimal Alan { get; set; }
        decimal BirimFiyat { get; set; }
        string MalSahibi { get; set; }
        string TelefonNo { get; set; }
        decimal Fiyat { get; set; }
        DateTime Tarih { get; set; }

        string İl();
        string Tip();
    }
}
