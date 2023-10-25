using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public abstract bool MegmentiAVilagot();

        public bool LegyoziE(ISzuperhos ellenfel)
        {
            if (ellenfel is Bosszuallo)
            {
                Bosszuallo ellenfelBosszuallo = (Bosszuallo)ellenfel;
                if (vanEGyengesege && ellenfelBosszuallo.VanEGyengesege)
                {
                    return szuperero > ellenfelBosszuallo.Szuperero;
                }
            }
            else if (ellenfel is Batman)
            {
                Batman batman = (Batman)ellenfel;
                return szuperero >= 2 * batman.MekkoraAzEreje();
            }
            return false;
        }

        public double MekkoraAzEreje()
        {
            return szuperero;
        }
        public override string ToString()
        {
            return $"Szupererő: {szuperero}{(vanEGyengesege ? "; van gyengesége" : "; nincs gyengesége")}";
        }
    }
}
