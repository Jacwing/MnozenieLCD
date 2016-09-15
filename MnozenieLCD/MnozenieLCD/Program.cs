using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnozenieLCD
{
    class Program
    {
        static void Main(string[] args)
        {
            CyfraSłownie[] pierwszaCyfraIloczynu = Cyfra.PokrywajaceSieCyfry(new bool[] { true, false, false, true, false, false, true });
            CyfraSłownie[] drugaCyfraIloczynu = Cyfra.PokrywajaceSieCyfry(new bool[] { true, false, false, true, false, false, true });
            CyfraSłownie[] trzeciaCyfraIloczynu = Cyfra.PokrywajaceSieCyfry(new bool[] { true, false, false, true, false, false, false });
            CyfraSłownie[] czwartaCyfraIloczynu = Cyfra.PokrywajaceSieCyfry(new bool[] { true, false, false, true, false, false, false });

            CyfraSłownie[] pierwszaCyfraPierwszegoSkładnika = Cyfra.PokrywajaceSieCyfry(new bool[] { true, false, false, false, false, false, false });
            CyfraSłownie[] drugaCyfraPierwszegoSkładnika = Cyfra.PokrywajaceSieCyfry(new bool[] { true, false, false, true, false, false, true });

            CyfraSłownie[] pierwszaCyfraDrugiegoSkładnik = Cyfra.PokrywajaceSieCyfry(new bool[] { false, false, false, false, false, false, true });
            CyfraSłownie[] drugaCyfraDrugiegoSkładnik = Cyfra.PokrywajaceSieCyfry(new bool[] { true, false, false, true, false, false, true });

            LiczbaDwuCyfrowa[] drugiSkładnik = LiczbaDwuCyfrowa.PodajNastepnąLiczbe(pierwszaCyfraDrugiegoSkładnik, drugaCyfraDrugiegoSkładnik).ToArray();

            foreach (var iloczyn in LiczbaCzteroCyfrowa.PodajNastepnąLiczbe(pierwszaCyfraIloczynu, drugaCyfraIloczynu, trzeciaCyfraIloczynu, czwartaCyfraIloczynu))
            {
                foreach (var pierwszySkładnik in LiczbaDwuCyfrowa.PodajNastepnąLiczbe(pierwszaCyfraPierwszegoSkładnika, drugaCyfraPierwszegoSkładnika))
                {
                    double sprawdzićDrugiSkładnik = (double)iloczyn.ToInt() / pierwszySkładnik.ToInt();
                    if ((sprawdzićDrugiSkładnik == (int)sprawdzićDrugiSkładnik) & drugiSkładnik.Any(r => r.ToInt() == sprawdzićDrugiSkładnik))
                    {
                        LiczbaDwuCyfrowa drugiSkłądnikJawnie = drugiSkładnik.First(r => r.ToInt() == sprawdzićDrugiSkładnik);


                        int[] sprawdzeniePowtarzaniaCyfr = new int[10];
                        foreach (var item in String.Format("{0}{1}{2}", pierwszySkładnik, drugiSkłądnikJawnie, iloczyn))
                        {
                            sprawdzeniePowtarzaniaCyfr[int.Parse(item.ToString())]++;
                        }
                        if (!sprawdzeniePowtarzaniaCyfr.Any(r => r > 1))
                        {
                            Console.WriteLine(String.Format("Rozwiązanie dla pierwszego warunku: {0} x {1} = {2}", pierwszySkładnik, drugiSkłądnikJawnie, iloczyn));
                        }


                        int[] sprawdznieWarDrugiego = new int[8];
                        string wszystkieSkładnikiRazem = String.Format("{0}{1}{2}", pierwszySkładnik, drugiSkłądnikJawnie, iloczyn);
                        for (int i = 0; i < 8; i++)
                        {
                            sprawdznieWarDrugiego[i] = int.Parse(wszystkieSkładnikiRazem[i].ToString());
                        }

                        if ((sprawdznieWarDrugiego[0] != sprawdznieWarDrugiego[1]) &
                            (sprawdznieWarDrugiego[0] != sprawdznieWarDrugiego[2]) &
                            (sprawdznieWarDrugiego[0] != sprawdznieWarDrugiego[3]) &
                            (sprawdznieWarDrugiego[0] != sprawdznieWarDrugiego[4]) &
                            (sprawdznieWarDrugiego[0] != sprawdznieWarDrugiego[5]) &
                            (sprawdznieWarDrugiego[0] != sprawdznieWarDrugiego[6]) &
                            (sprawdznieWarDrugiego[0] != sprawdznieWarDrugiego[7]) &
                            (sprawdznieWarDrugiego[1] != sprawdznieWarDrugiego[0]) &
                            (sprawdznieWarDrugiego[1] != sprawdznieWarDrugiego[2]) &
                            (sprawdznieWarDrugiego[1] != sprawdznieWarDrugiego[6]) &
                            (sprawdznieWarDrugiego[1] != sprawdznieWarDrugiego[7]) &
                            (sprawdznieWarDrugiego[2] != sprawdznieWarDrugiego[0]) &
                            (sprawdznieWarDrugiego[2] != sprawdznieWarDrugiego[1]) &
                            (sprawdznieWarDrugiego[2] != sprawdznieWarDrugiego[3]) &
                            (sprawdznieWarDrugiego[2] != sprawdznieWarDrugiego[4]) &
                            (sprawdznieWarDrugiego[2] != sprawdznieWarDrugiego[5]) &
                            (sprawdznieWarDrugiego[2] != sprawdznieWarDrugiego[6]) &
                            (sprawdznieWarDrugiego[2] != sprawdznieWarDrugiego[7]) &
                            (sprawdznieWarDrugiego[3] != sprawdznieWarDrugiego[0]) &
                            (sprawdznieWarDrugiego[3] != sprawdznieWarDrugiego[2]) &
                            (sprawdznieWarDrugiego[3] != sprawdznieWarDrugiego[6]) &
                            (sprawdznieWarDrugiego[3] != sprawdznieWarDrugiego[7]) &
                            (sprawdznieWarDrugiego[4] != sprawdznieWarDrugiego[0]) &
                            (sprawdznieWarDrugiego[4] != sprawdznieWarDrugiego[2]) &
                            (sprawdznieWarDrugiego[4] != sprawdznieWarDrugiego[6]) &
                            (sprawdznieWarDrugiego[4] != sprawdznieWarDrugiego[7]) &
                            (sprawdznieWarDrugiego[5] != sprawdznieWarDrugiego[0]) &
                            (sprawdznieWarDrugiego[5] != sprawdznieWarDrugiego[2]) &
                            (sprawdznieWarDrugiego[5] != sprawdznieWarDrugiego[6]) &
                            (sprawdznieWarDrugiego[5] != sprawdznieWarDrugiego[7]) &
                            (sprawdznieWarDrugiego[6] != sprawdznieWarDrugiego[0]) &
                            (sprawdznieWarDrugiego[6] != sprawdznieWarDrugiego[1]) &
                            (sprawdznieWarDrugiego[6] != sprawdznieWarDrugiego[2]) &
                            (sprawdznieWarDrugiego[6] != sprawdznieWarDrugiego[3]) &
                            (sprawdznieWarDrugiego[6] != sprawdznieWarDrugiego[4]) &
                            (sprawdznieWarDrugiego[6] != sprawdznieWarDrugiego[5]) &
                            (sprawdznieWarDrugiego[7] != sprawdznieWarDrugiego[0]) &
                            (sprawdznieWarDrugiego[7] != sprawdznieWarDrugiego[1]) &
                            (sprawdznieWarDrugiego[7] != sprawdznieWarDrugiego[2]) &
                            (sprawdznieWarDrugiego[7] != sprawdznieWarDrugiego[3]) &
                            (sprawdznieWarDrugiego[7] != sprawdznieWarDrugiego[4]) &
                            (sprawdznieWarDrugiego[7] != sprawdznieWarDrugiego[5]))
                        {
                            Console.WriteLine(String.Format("Rozwiązanie dla drugiego warunku: {0} x {1} = {2}", pierwszySkładnik, drugiSkłądnikJawnie, iloczyn));
                        }
                        
                    }
                }
            }
            Console.ReadKey();
        }
    }

    class LiczbaCzteroCyfrowa
    {
        private CyfraSłownie cyfraTysiecy;
        private CyfraSłownie cyfraSetek;
        private CyfraSłownie cyfraDziesiatek;
        private CyfraSłownie cyfraJedności;

        private LiczbaCzteroCyfrowa() { }

        public LiczbaCzteroCyfrowa(CyfraSłownie cyfraTysiecy, CyfraSłownie cyfraSetek, CyfraSłownie cyfraDziesiatek, CyfraSłownie cyfraJedności)
        {
            this.cyfraTysiecy = cyfraTysiecy;
            this.cyfraSetek = cyfraSetek;
            this.cyfraDziesiatek = cyfraDziesiatek;
            this.cyfraJedności = cyfraJedności;
        }

        public override string ToString()
        {
            return (((int)cyfraTysiecy).ToString() + ((int)cyfraSetek).ToString() + ((int)cyfraDziesiatek).ToString() + ((int)cyfraJedności).ToString());
        }

        public int ToInt()
        {
            return (((int)cyfraTysiecy) * 1000 + ((int)cyfraSetek) * 100 + ((int)cyfraDziesiatek) * 10 + ((int)cyfraJedności));
        }

        public static IEnumerable<LiczbaCzteroCyfrowa> PodajNastepnąLiczbe(CyfraSłownie[] cyfryTysięcy, CyfraSłownie[] cyfrySetek, CyfraSłownie[] cyfryDziesiatek, CyfraSłownie[] cyfryJednosci)
        {
            for (int i = 0; i < cyfryTysięcy.Length; i++)
            {
                if (cyfryTysięcy[i] != 0)
                    for (int j = 0; j < cyfrySetek.Length; j++)
                    {
                        for (int n = 0; n < cyfryDziesiatek.Length; n++)
                        {
                            for (int m = 0; m < cyfryJednosci.Length; m++)
                            {
                                yield return new LiczbaCzteroCyfrowa(cyfryTysięcy[i], cyfrySetek[j], cyfryDziesiatek[n], cyfryJednosci[m]);
                            }
                        }
                    }
            }
        }

    }

    class LiczbaDwuCyfrowa
    {

        private CyfraSłownie cyfraDziesiatek;
        private CyfraSłownie cyfraJedności;

        private LiczbaDwuCyfrowa() { }

        public LiczbaDwuCyfrowa(CyfraSłownie cyfraDziesiatek, CyfraSłownie cyfraJedności)
        {
            this.cyfraDziesiatek = cyfraDziesiatek;
            this.cyfraJedności = cyfraJedności;
        }

        public override string ToString()
        {
            return (((int)cyfraDziesiatek).ToString() + ((int)cyfraJedności).ToString());
        }

        public int ToInt()
        {
            return (((int)cyfraDziesiatek) * 10 + ((int)cyfraJedności));
        }

        public static IEnumerable<LiczbaDwuCyfrowa> PodajNastepnąLiczbe(CyfraSłownie[] cyfryDziesiatek, CyfraSłownie[] cyfryJednosci)
        {

            for (int n = 0; n < cyfryDziesiatek.Length; n++)
            {
                if (cyfryDziesiatek[n] != 0)
                    for (int m = 0; m < cyfryJednosci.Length; m++)
                    {
                        yield return new LiczbaDwuCyfrowa(cyfryDziesiatek[n], cyfryJednosci[m]);
                    }
            }
        }

    }

    class Cyfra
    {
        /// <summary>
        ///     0
        ///   5   1
        ///     6
        ///   4   2
        ///     3    
        ///   _       _   _
        ///  | |  |   _|  _| 
        ///  |_|  |  |_   _|
        /// </summary>
        private bool[] kreski;

        bool[] Kreski
        {
            get { return kreski; }
        }

        private Cyfra() { }

        public Cyfra(CyfraSłownie cyfraSłownie)
        {
            switch (cyfraSłownie)
            {
                case CyfraSłownie.Zero:
                    kreski = new bool[] { true, true, true, true, true, true, false }; //0,1,2,3,4,5
                    break;
                case CyfraSłownie.Jeden:
                    kreski = new bool[] { false, true, true, false, false, false, false }; //1,2
                    break;
                case CyfraSłownie.Dwa:
                    kreski = new bool[] { true, true, false, true, true, false, true }; //0,1,3,4,6
                    break;
                case CyfraSłownie.Trzy:
                    kreski = new bool[] { true, true, true, true, false, false, true }; //0,1,2,3,5
                    break;
                case CyfraSłownie.Cztery:
                    kreski = new bool[] { false, true, true, false, false, true, true }; //1,2,5,6
                    break;
                case CyfraSłownie.Pięć:
                    kreski = new bool[] { true, false, true, true, false, true, true }; //0,2,3,5,6
                    break;
                case CyfraSłownie.Sześć:
                    kreski = new bool[] { true, false, true, true, true, true, true }; //0,2,3,4,5,6
                    break;
                case CyfraSłownie.Siedem:
                    kreski = new bool[] { true, true, true, false, false, false, false }; //0,1,2
                    break;
                case CyfraSłownie.Osiem:
                    kreski = new bool[] { true, true, true, true, true, true, true }; //0,1,2,3,4,5,6
                    break;
                case CyfraSłownie.Dziewięć:
                    kreski = new bool[] { true, true, true, true, false, true, true }; //0,1,2,3,5,6
                    break;
                default:
                    kreski = new bool[] { false, false, false, false, false, false, false };
                    break;
            }
        }

        public bool CzyPokrywaSie(bool[] podejrzaneKreski)
        {
            bool wynik = false;
            int licznikPorownań = 0;
            if (podejrzaneKreski.Length == 7)
            {
                for (int i = 0; i < kreski.Length; i++)
                {
                    if (!podejrzaneKreski[i] || kreski[i])
                        licznikPorownań++;
                }
            }
            if (licznikPorownań == kreski.Length)
                wynik = true;

            return wynik;
        }

        public static CyfraSłownie[] PokrywajaceSieCyfry(bool[] podejrzaneKreski)
        {
            List<CyfraSłownie> wynik = new List<CyfraSłownie>();

            foreach (CyfraSłownie item in Enum.GetValues(typeof(CyfraSłownie)))
            {
                Cyfra cyfra = new Cyfra(item);
                if (cyfra.CzyPokrywaSie(podejrzaneKreski))
                    wynik.Add(item);
            }

            return wynik.ToArray();
        }
    }

    public enum CyfraSłownie
    {
        Zero = 0,
        Jeden = 1,
        Dwa = 2,
        Trzy = 3,
        Cztery = 4,
        Pięć = 5,
        Sześć = 6,
        Siedem = 7,
        Osiem = 8,
        Dziewięć = 9
    }
}
