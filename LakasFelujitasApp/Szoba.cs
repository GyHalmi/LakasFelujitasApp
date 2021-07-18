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

        public List<Fal> Falak;

        public Szoba(string nev, double szelesseg, double hossz, double kiesoSzelesseg, double kiesoHossz, double magassag)
        {
            Nev = nev;
            Szelesseg = szelesseg;
            Hossz = hossz;
            Magassag = magassag;
            KiesoSzelesseg = kiesoSzelesseg;
            KiesoHossz = kiesoHossz;
            mindenSzoba.Add(this);

            Falak = new List<Fal>() { new Fal(szelesseg), new Fal(hossz), new Fal(szelesseg - kiesoSzelesseg), new Fal(kiesoHossz), new Fal(kiesoSzelesseg), new Fal(hossz - kiesoHossz) };

            bool nullaSzelesseg(Fal f)
            {
                return f.Szelesseg == 0;
            }
            Falak.RemoveAll(nullaSzelesseg);

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

        public List<Nyilaszaro> nyilaszarok()
        {
            List<Nyilaszaro> nyil = new List<Nyilaszaro>();
            foreach (var f in Falak)
            {
                nyil.AddRange(f.Nyilaszarok);
            }
            return nyil;
        }

        public double osszFalfelulet()
        {
            double ossz = 0;
            foreach (var f in Falak)
            {
                f.f
            }
            return Math.Round(falFeluletPlafonnal() - nyilaszarokFelulete(), 2);
        }

        public double festendoFelulet(double magassag)
        {
            if (magassag > Magassag) magassag = Magassag;
            double felulet = 0;
            foreach (var fal in Falak)
            {
                if (fal.Festendo)
                {
                    felulet += fal.Szelesseg * magassag;
                    foreach (var ny in fal.Nyilaszarok)
                    {
                        if (magassag > ny.BeepitesiMagassag) felulet -= ny.Szelesseg * (magassag - ny.BeepitesiMagassag);
                    } 
                }
            }
            return felulet;
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

        public void falakatFest(bool b)
        {
            foreach (var fal in Falak)
            {
                fal.Festendo = b;
            }
        }

        public void falakatFest(int falIndex, bool b)
        {
            Falak[falIndex].Festendo = b;
        }


    }

}


