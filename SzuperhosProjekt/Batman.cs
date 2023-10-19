using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    internal class Batman : ISzuperhos, Milliardos
    {
        private double lelemenyesseg;

        public double Lelemenyesseg { get => lelemenyesseg; set => lelemenyesseg = value; }

        public Batman()
        {
            Lelemenyesseg = 100;
        }

        public bool LegyoziE(ISzuperhos ellenfel)
        {
            if (ellenfel.MekkoraAzEreje() < Lelemenyesseg * 2)
            {
                return true;
            }
            return false;
        }

        public double MekkoraAzEreje()
        {
            return Lelemenyesseg * 2;
        }

        public void KutyutKeszit()
        {
            Lelemenyesseg += 50;
        }

        public override string ToString()
        {
            return $"Batman: leleményesség: {Lelemenyesseg}";
        }
    }
}
