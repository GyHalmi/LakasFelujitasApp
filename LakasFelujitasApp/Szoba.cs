using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakasFelujitasApp
{
    class Szoba
    {
        public static List<Szoba> mindenSzoba = new List<Szoba>();
        private static double alapMagassag = 2.64;
        public string Nev { get; set; }
        public double Szelesseg { get; set; }
        public double Hossz { get; set; }
        public double Magassag { get; set; }
        public double KiesoSzelesseg { get; set; }
        public double KiesoHossz { get; set; }


        public List<Nyilaszaro> nyilaszarok;

        public Szoba(string nev, double szelesseg, double hossz, double kiesoSzelesseg, double kiesoHossz, double magassag)
        {
            Nev = nev;
            Szelesseg = szelesseg;
            Hossz = hossz;
            Magassag = magassag;
            KiesoSzelesseg = kiesoSzelesseg;
            KiesoHossz = kiesoHossz;
            mindenSzoba.Add(this);
            nyilaszarok = new List<Nyilaszaro>();
        }
        public Szoba(string nev, double szelesseg, double hossz, double kiesoSzelesseg, double kiesoHossz) : this(nev, szelesseg, hossz, kiesoHossz, kiesoSzelesseg, alapMagassag)
        {
            ;
        }
        public Szoba(string nev, double szelesseg, double hossz, double magassag) : this(nev, szelesseg, hossz, 0, 0, magassag)
        {
            ;
        }

        public Szoba(string nev, double szelesseg, double hossz) : this(nev, szelesseg, hossz, 0, 0, alapMagassag)
        {
            ;
        }

        public double alapterulet()
        {
            double alap = Szelesseg * Hossz - KiesoSzelesseg * KiesoHossz;
            return Math.Round(alap, 2);
        }
        public double kerulet()
        {
            double ker = Szelesseg * 2 + Hossz * 2;
            return Math.Round(ker, 2);
        }

        public double falFeluletPlafonnal()
        {
            return kerulet() * Magassag + alapterulet();
        }

        public double nyilaszarokFelulete()
        {
            double osszfelulet = 0;
            foreach (var ny in nyilaszarok)
            {
                osszfelulet += ny.felulet();
            }
            return osszfelulet;
        }

        public double festendoFeluletPlafonnal()
        {
            return Math.Round(falFeluletPlafonnal() - nyilaszarokFelulete(), 2);
        }

        public double festendoFeluletAdottMagassagig(double magassag)
        {
            if (magassag > Magassag) magassag = Magassag;
            return kerulet() * magassag - nyilaszarokFelulete();
        }

        public double szegolec()
        {
            double korr = 0;
            foreach (var nyil in nyilaszarok)
            {
                korr += nyil.SzegolecKorrekcio;
            }
            return Math.Round(kerulet() + korr, 2);
        }

        public Point[] alaprajz()
        {
            int rajzMeret(double meret)
            {
                return (int)(meret * 20);
            }

            Point kezdo = new Point(30, 60);

            int rovidSzel = rajzMeret(Szelesseg) - rajzMeret(KiesoSzelesseg);
            int rovidHossz = rajzMeret(Hossz) - rajzMeret(KiesoHossz);

            //Point p1 = new Point(kezdo.X + rovidSzel, kezdo.Y);
            //Point p2 = new Point(kezdo.X + rovidSzel, kezdo.Y + rajzMeret(KiesoHossz));
            //Point p3 = new Point(kezdo.X + rajzMeret(Szelesseg), kezdo.Y + rajzMeret(KiesoHossz));
            //Point p4 = new Point(kezdo.X + rajzMeret(Szelesseg), kezdo.Y + rajzMeret(Hossz));
            //Point p5 = new Point(kezdo.X, kezdo.Y + rajzMeret(Hossz));

            Point p1 = new Point(kezdo.X + rajzMeret(Szelesseg), kezdo.Y);
            Point p2 = new Point(kezdo.X + rajzMeret(Szelesseg), kezdo.Y + rajzMeret(Hossz));
            Point p3 = new Point(kezdo.X + rajzMeret(KiesoSzelesseg), kezdo.Y + rajzMeret(Hossz));
            Point p4 = new Point(kezdo.X + rajzMeret(KiesoSzelesseg), kezdo.Y + rovidHossz);
            Point p5 = new Point(kezdo.X, kezdo.Y + rovidHossz);

            Point[] pontok = { kezdo, p1, p2, p3, p4, p5 };

            return pontok;
        }
        public List<double> falakEgyesevel()
        {
            List<double> falak = new List<double>(){ Szelesseg, Hossz };
            if(KiesoHossz == 0 && KiesoSzelesseg == 0)
            {
                falak.AddRange(falak);
            }
            else
            {
                falak.Add(Szelesseg - KiesoSzelesseg);
                falak.Add(KiesoHossz);
                falak.Add(KiesoSzelesseg);
                falak.Add(Hossz - KiesoHossz);
            }
            return falak;
        }
    }

}


