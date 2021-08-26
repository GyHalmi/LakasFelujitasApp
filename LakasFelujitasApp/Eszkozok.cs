using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakasFelujitasApp
{
    static class Eszkozok
    {
        public static Szoba tagOlvaso(Control control)
        {
            //try
            //{
            //    return (Szoba)control.Tag;
            //}
            //catch (NullReferenceException)
            //{
            //    return null;
            //}
            return (Szoba)control.Tag;
        }

        public static double txtToDecimal(TextBox txt) // helyette szoba.meretekMegadasa() // így a Szoba osztaly winFormhoz kötött lett
        {
            Double.TryParse(txt.Text, out double d);
            return d;
        }
    }
}
