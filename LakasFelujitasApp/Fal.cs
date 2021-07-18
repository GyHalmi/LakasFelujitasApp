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
        public List<Nyilaszaro> Nyilaszarok { get; set; }
        public bool Festendo { get; set; }

        public Fal(double szelesseg)
        {
            Szelesseg = szelesseg;
            Nyilaszarok = new List<Nyilaszaro>();
            Festendo = false;
        }
    }
}
