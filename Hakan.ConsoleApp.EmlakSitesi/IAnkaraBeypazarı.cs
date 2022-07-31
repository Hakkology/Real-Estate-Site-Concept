using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.EmlakSitesi
{
    public interface IAnkaraBeypazarı:IAnkara
    {
        string İlçe();
        decimal FiyatHesap();
        void MalGösterim();
    }
}
