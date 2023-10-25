using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        public Vasember() : base(150, true)
        {
        }

        public override bool MegmentiAVilagot()
        {
            return Szuperero > 1000;
        }

        public void KutyutKeszit()
        {
            Random rnd = new Random();
            double noveles = rnd.NextDouble()*10 ;
            Szuperero += noveles;
        }

        public override string ToString()
        {
            return "Vasember: " + base.ToString();
        }
    }
}
