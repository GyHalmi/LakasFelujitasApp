using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace LakasFelujitasApp
{
    public enum Alapterulet { Szabalyos, Szabalytalan };
    class Szoba
    {
        public static List<Szoba> mindenSzoba = new List<Szoba>();
        private static double alapMagassag = 2.64;
        public string Nev { get; set; }
        public Alapterulet AlapteruletTipus { get; set; }
        public double Szelesseg { get; set; }
        public double Hossz { get; set; }
        public double FesthetoMagassag { get; set; }
        public double KiesoSzelesseg { get; set; }
        public double KiesoHossz { get; set; }

        public List<Fal> Falak;

        private static string mentesHelye = "mentettSzobak.txt";


        public static void szobaKesz(Szoba szoba)
        {
            mindenSzoba.Add(szoba);
            mentesFajlba();
        }
        private static string[] mindenSzobaTomb()
        {
            string fejlec = "Nev;AlapteruletTipus;Szelesseg;Hossz;KiesoSzelesseg;KiesoHossz;FesthetoMagassag";
            string[] szobak = new string[mindenSzoba.Count + 1];
            szobak[0] = fejlec;
            string szobaInfo(Szoba sz)
            {
                return $"{sz.Nev};{(int)sz.AlapteruletTipus};{sz.Szelesseg};{sz.Hossz};{sz.KiesoSzelesseg};{sz.KiesoHossz};{sz.FesthetoMagassag}";
            }
            for (int i = 0; i < mindenSzoba.Count; i++)
            {
                szobak[i + 1] = szobaInfo(mindenSzoba[i]);
            }
            return szobak;
        }
        private static void mentesFajlba()
        {
            File.WriteAllLines(mentesHelye, mindenSzobaTomb());
            //string jsonString = JsonSerializer.Serialize(mindenSzoba[0]);
            //File.WriteAllText(mentesHelye, jsonString);

        }

        public static void betoltesFajlbol()
        {
            string[] sorok = File.ReadAllLines(mentesHelye);

            for (int i = 1; i < sorok.Length; i++) //skip first row
            {
                string[] meretek = sorok[i].Split(';');
                string nev = meretek[0];
                Alapterulet alapTer = (Alapterulet)int.Parse( meretek[1]);
                double szel = double.Parse(meretek[2]);
                double hossz = double.Parse(meretek[3]);
                double kiesoSzel = double.Parse(meretek[4]);
                double kiesoHossz = double.Parse(meretek[5]);
                double mag = double.Parse(meretek[6]);
                //Szoba sz = new Szoba()


 
            }
        }

        public Szoba(string nev, Alapterulet alapteruletTipus)
        {
            Nev = nev;
            AlapteruletTipus = alapteruletTipus;
            Falak = new List<Fal>();
        }
        public void meretekMegadasa(double szelesseg, double hossz, double kiesoSzelesseg, double kiesoHossz, double festhetoMagassag)
        {
            if (festhetoMagassag == 0) festhetoMagassag = 1;
            Szelesseg = szelesseg;
            Hossz = hossz;
            FesthetoMagassag = festhetoMagassag;
            KiesoSzelesseg = kiesoSzelesseg;
            KiesoHossz = kiesoHossz;

            Falak = new List<Fal>() { new Fal(szelesseg, festhetoMagassag), new Fal(hossz, festhetoMagassag), new Fal(szelesseg - kiesoSzelesseg, festhetoMagassag), new Fal(kiesoHossz, festhetoMagassag), new Fal(kiesoSzelesseg, festhetoMagassag), new Fal(hossz - kiesoHossz, festhetoMagassag) };

            bool nullaSzelesseg(Fal f)
            {
                return f.Szelesseg == 0;
            }
            Falak.RemoveAll(nullaSzelesseg);
        }
        public void meretekMegadasa(string szelesseg, string hossz, string kiesoSzelesseg, string kiesoHossz, string festhetoMagassag)
        {
            double strToDouble(string str)
            {
                double.TryParse(str, out double d);
                return d;
            }

            meretekMegadasa(strToDouble(szelesseg), strToDouble(hossz), strToDouble(kiesoSzelesseg), strToDouble(kiesoHossz), strToDouble(festhetoMagassag));
        }

        public void meretekMegadasa(TextBox szelesseg, TextBox hossz, TextBox kiesoSzelesseg, TextBox kiesoHossz, TextBox festhetoMagassag)
        {
            meretekMegadasa(szelesseg.Text, hossz.Text, kiesoSzelesseg.Text, kiesoHossz.Text, festhetoMagassag.Text);
        }

        public void meretekMegadasa(double szelesseg, double hossz, double festhetoMagassag)
        {
            meretekMegadasa(szelesseg, hossz, 0, 0, festhetoMagassag);
        }


        public Szoba(string nev, double szelesseg, double hossz, double kiesoSzelesseg, double kiesoHossz, double festhetoMagassag)
        {
            Nev = nev;
            Szelesseg = szelesseg;
            Hossz = hossz;
            FesthetoMagassag = festhetoMagassag;
            KiesoSzelesseg = kiesoSzelesseg;
            KiesoHossz = kiesoHossz;
            mindenSzoba.Add(this);

            Falak = new List<Fal>() { new Fal(szelesseg, festhetoMagassag), new Fal(hossz, festhetoMagassag), new Fal(szelesseg - kiesoSzelesseg, festhetoMagassag), new Fal(kiesoHossz, festhetoMagassag), new Fal(kiesoSzelesseg, festhetoMagassag), new Fal(hossz - kiesoHossz, festhetoMagassag) };

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
            return Szelesseg * Hossz - KiesoSzelesseg * KiesoHossz;
        }
        public double kerulet()
        {
            return Szelesseg * 2 + Hossz * 2;
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
        public void nyilaszarokTorles()
        {
            foreach (var f in Falak)
            {
                f.Nyilaszarok.Clear();
            }
        }

        public double osszFalfelulet()
        {
            double ossz = 0;
            bool allapot = false;
            foreach (var f in Falak)
            {
                allapot = f.Festendo;
                f.Festendo = true;
                ossz += f.reszlegesFalfestes(f.Magassag);
                f.Festendo = allapot;
            }
            return ossz + alapterulet();
        }

        public double festendoFelulet(double magassag)
        {
            double ossz = 0;
            foreach (var f in Falak)
            {
                ossz += f.reszlegesFalfestes(magassag);
            }

            return ossz;
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
        public override string ToString()
        {
            return $"Nev={Nev}; AlapteruletTipus={AlapteruletTipus}; " +
                $"Szelesseg{Szelesseg}; Hossz={Hossz}; " +
                $"KiesoSzelesseg={KiesoSzelesseg}; KiesoHossz={KiesoHossz}; " +
                $"festhetoMagassag={FesthetoMagassag}";
        }

    }

}


