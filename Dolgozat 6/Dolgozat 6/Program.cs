using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_6
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1(); Console.WriteLine("\n-----------------------\n");
            Feladat2(); Console.WriteLine("\n-----------------------\n");
            Feladat3(); Console.WriteLine("\n-----------------------\n");
            Feladat4(); Console.WriteLine("\n-----------------------\n");
            Feladat5DoWhile(); Console.WriteLine("\n-----------------------\n");
            Console.ReadKey();
        }

        

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: az első 30 5-el és 12-el. ami 24-el is oszthatü pirosra szinezze");
            int db = 0;
            int Ertek = 0;
            do
            {                
                Ertek++;
                if (Ertek % 5 == 0 && Ertek % 12 == 0)
                {
                    db++;                    
                    if (Ertek % 24 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0} , ", Ertek);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("{0} , ", Ertek);
                    }
                }
            } while (db < 30);
               
        }
        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: rulettkerék");
            int PorgetettErtek = 0;
            double Osszeg = 0;
            double Atlag = 0;
            int db11=0;
            for (int i = 1; i < 13; i++)
            {
                PorgetettErtek = rnd.Next(0, 37);
                Console.WriteLine("\t{0:00}. pörgetés -> érték: {1}",i,PorgetettErtek);
                Osszeg += PorgetettErtek;
                Atlag = Osszeg / 12;
                if(PorgetettErtek==11)
                { db11++; }
                if(PorgetettErtek==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\tRendkívüli nyeremény");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.WriteLine("\tA 12 pörgetés összege: {0}", Osszeg);
            Console.WriteLine("\tA 12 pörgetés átlaga: {0}", Atlag);
            Console.WriteLine("\tA 12 pörgetésből ennyi elkalommal jött ki a 11: {0}", db11);

        }
        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: Forgáskúp térfogat, felszín");
            Console.Write("Kérem adja meg a forgáskúp sugarát: ");
            double Sugar = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a forgáskúp magasságát: ");
            double Magassag = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a forgáskúp alkotóját: ");
            double Alkoto = double.Parse(Console.ReadLine());
            double Terfogat = (Math.PI * Math.Pow(Sugar, 2) * Magassag) / 3;
            Console.WriteLine("\tA forgáskúp térfogata: {0:0.00} cm3", Terfogat);
            double Felszin = Math.PI * Sugar * (Sugar + Alkoto);
            Console.WriteLine("\tA forgáskúp felszíne: {0:0.00} cm2", Felszin);

        }
        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat: osztályzat");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            Console.Write("Kérem adja meg az osztályát: ");
            string Osztaly = Console.ReadLine();
            int Pontszam = 0;
            int Osszpontszam = 0;
            for (int i = 1; i < 6; i++)
            {
                Pontszam = rnd.Next(0, 20);
                Console.WriteLine("{0:00} feladat -> pontszám: {1}",i, Pontszam);
                Osszpontszam += Pontszam;
            }
            Console.WriteLine("\tDolgozat össz pontszámai: {0}",Osszpontszam);
            if(Osszpontszam<=42)
            {
                Console.WriteLine("Gratulálok {0} ({1}) az Ön pontszáma összesen: {2} osztályzata: elégtelen", Nev, Osztaly, Osszpontszam);
            }
            if (43<=Osszpontszam && Osszpontszam<= 57)
            {
                Console.WriteLine("Gratulálok {0} ({1}) az Ön pontszáma összesen: {2} osztályzata: elégséges", Nev, Osztaly, Osszpontszam);
            }
            if (58 <= Osszpontszam && Osszpontszam <= 72)
            {
                Console.WriteLine("Gratulálok {0} ({1}) az Ön pontszáma összesen: {2} osztályzata: közepes", Nev, Osztaly, Osszpontszam);
            }
            if (73 <= Osszpontszam && Osszpontszam <= 87)
            {
                Console.WriteLine("Gratulálok {0} ({1}) az Ön pontszáma összesen: {2} osztályzata: jó", Nev, Osztaly, Osszpontszam);
            }
            if (88 <= Osszpontszam && Osszpontszam <= 100)
            {
                Console.WriteLine("Gratulálok {0} ({1}) az Ön pontszáma összesen: {2} osztályzata: jeles", Nev, Osztaly, Osszpontszam);
            }
        }
        private static void Feladat5DoWhile()
        {
            Console.WriteLine("5.Feladat: számok generálása 100-300 között amik oszthatók 3-al és 7-el");
            int Szam = 100;
            do
            {
                Szam++;
                if(Szam%3==0 && Szam%7==0)
                {
                    Console.Write("\t{0} , ",Szam);
                }
            } while (Szam < 301);
        }
    }
}
