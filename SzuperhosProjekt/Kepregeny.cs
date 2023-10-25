using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();
        
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

                            ISzuperhos szuperhos;
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
                                if (szuperhos is Vasember)
                                {
                                    Vasember vasember = (Vasember)szuperhos;
                                    vasember.KutyutKeszit();
                                }
                                else if (szuperhos is Batman)
                                {
                                    Batman batman = (Batman)szuperhos;
                                    batman.KutyutKeszit();
                                }
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
            foreach (IMilliardos szuperhos in szuperhosok)
            {
                Console.WriteLine(szuperhos);
            }
        }
    }
}
