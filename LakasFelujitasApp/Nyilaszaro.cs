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
        public double BeepitesiMagassag { get; set; }
        public double SzegolecKorrekcio { get; set; }


        public Nyilaszaro(double szelesseg, double magassag, double beepitesiMagassag, double szegolecKorrekcio)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
            BeepitesiMagassag = beepitesiMagassag;
            SzegolecKorrekcio = szegolecKorrekcio;
        }

        public Nyilaszaro(double szelesseg, double magassag): this(szelesseg, magassag,1,0)
        {
            ;
        }

        public double felulet()
        {
            return Szelesseg * Magassag;
        }


    }
}
