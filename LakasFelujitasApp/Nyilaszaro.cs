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
       

        public Nyilaszaro(double szelesseg, double magassag, double beepitesiMagassag)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
            BeepitesiMagassag = beepitesiMagassag;
        }

        public double felulet()
        {
            return Szelesseg * Magassag;
        }

        public override string ToString()
        {
            return $"{Szelesseg} x {Magassag} ({BeepitesiMagassag})";
        }


    }
}
