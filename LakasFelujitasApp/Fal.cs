using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakasFelujitasApp
{
    class Fal
    {
        public double Szelesseg { get; set; }
        public double Magassag { get; set; }
        public List<Nyilaszaro> Nyilaszarok { get; set; }
        public bool Festendo { get; set; }

        public Fal(double szelesseg, double magassag)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
            Nyilaszarok = new List<Nyilaszaro>();
            Festendo = false;
        }

        public void nyilaszarotHozzaad(double szelesseg, double magassag, double beepitesiMagassag)
        {
            Nyilaszarok.Add(new Nyilaszaro(szelesseg, magassag, beepitesiMagassag));
        }

        public double reszlegesFalfestes(double alsoHatar, double felsoHatar)
        {
            if (felsoHatar > Magassag) felsoHatar = Magassag;
            if (alsoHatar < 0) alsoHatar = 0;
            double felulet = 0;

            if (Festendo)
            {
                felulet += Szelesseg * (felsoHatar - alsoHatar);
                foreach (var ny in Nyilaszarok)
                {
                    if (felsoHatar > ny.BeepitesiMagassag) felulet -= ny.Szelesseg * (felsoHatar - ny.BeepitesiMagassag);
                }
            }

            return felulet;
        }

        public double reszlegesFalfestes(double felsoHatar)
        {
            return reszlegesFalfestes(0, felsoHatar);
        }
    }
}
