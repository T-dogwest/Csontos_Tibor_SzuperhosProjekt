using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    internal static class Kepregeny
    {
        public static List<Milliardos> szuperhosok = new List<Milliardos>();

        public static void Szereplok(string faljnev)
        {
            try
            {
                using (StreamReader reader = new StreamReader(faljnev))
                {
                    string sor;
                    while ((sor = reader.ReadLine()) != null)
                    {
                        string[] adatok = sor.Split(' ');
                        if (adatok.Length == 2)
                        {
                            string nev = adatok[0];
                            int szam = int.Parse(adatok[1]);

                            Milliardos szuperhos;
                            if (nev == "Vasember")
                            {
                                szuperhos = new Vasember();
                            }
                            else
                            {
                                szuperhos = new Batman();
                            }


                            for (int i = 0; i < szam; i++)
                            {
                                szuperhos.KutyutKeszit();
                            }

                            szuperhosok.Add(szuperhos);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Hiba történt: " + ex.Message);
            }


        }
        public static void Szuperhosok()
        {
            foreach (Milliardos szuperhos in szuperhosok)
            {
                Console.WriteLine(szuperhos);
            }
        }
    }
}
