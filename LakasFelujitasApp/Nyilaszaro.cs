using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakasFelujitasApp
{
    class Nyilaszaro
    {
        public double Szelesseg { get; set; }
        public double Magassag { get; set; }
        public double SzegolecKorrekcio { get; set; }

        public Nyilaszaro(double szelesseg, double magassag, double szegolecKorrekcio)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
            SzegolecKorrekcio = szegolecKorrekcio;
        }
        public Nyilaszaro(double szelesseg, double magassag): this(szelesseg, magassag,0)
        {
            ;
        }

        public double felulet()
        {
            return Szelesseg * Magassag;
        }

    }
}
