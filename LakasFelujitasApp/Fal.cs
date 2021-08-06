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
        public bool Festendo { get; set; }
        public List<Nyilaszaro> Nyilaszarok { get; set; }

        public Fal(double szelesseg, double magassag)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
            Festendo = false;
            Nyilaszarok = new List<Nyilaszaro>();
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
                    double nyilasAlja = ny.BeepitesiMagassag;
                    double nyilasTeteje = ny.BeepitesiMagassag + ny.Magassag;

                    bool nyilasMagassagban(double festesiHatar)
                    {
                        return festesiHatar > nyilasAlja && festesiHatar < nyilasTeteje;
                    }
               
                    if (nyilasMagassagban(felsoHatar) && nyilasMagassagban(alsoHatar))
                    {
                        felulet -= (felsoHatar - alsoHatar) * ny.Szelesseg;
                    }
                    else if (nyilasMagassagban(felsoHatar))
                    {
                        felulet -= (felsoHatar - nyilasAlja) * ny.Szelesseg;
                    }
                    else if(nyilasMagassagban(alsoHatar))
                    {
                        felulet -= (nyilasTeteje - alsoHatar) * ny.Szelesseg;
                    }
                    else if(felsoHatar> nyilasTeteje && alsoHatar< nyilasAlja)
                    {
                        felulet -= ny.felulet();
                    }
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
