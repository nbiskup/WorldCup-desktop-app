using RwaLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPF
{
    public class Utils
    {
        public static void PostaviKulturu(Jezici jezici)
        {
            CultureInfo kultura;
            if (jezici == Jezici.Hrvatski)
            {
                kultura = new CultureInfo("hr");
            }
            else
            {
                kultura = new CultureInfo("en");
            }
            Thread.CurrentThread.CurrentUICulture = kultura;

        }
    }
}
