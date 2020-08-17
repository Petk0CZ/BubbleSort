using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            Console.Write("Zadejte počet znaků: ");
            int delka = int.Parse(Console.ReadLine());
            Console.WriteLine(delka);
            int[] pole = new int[delka];
            int[] serazeno = new int[delka];
            int[] tabulka = new int[delka];

            Random random = new Random();

            for (int i = 1; i < delka; i++)
            {
                cislo = random.Next(1, delka);
                    {
                        pole[i] = cislo;
                    }                             
            }
            for (int vypis = 1; vypis < delka; vypis++)
            {
                Console.WriteLine(pole[vypis]);
            }

            for (int tab = 1; tab < delka; tab++)
            {
                tabulka[tab] = tab;
            }

            //výpis tabulky
            for (int i = 1; i < delka; i++)
            {

            }

            //porovnání

            for (int p = 1; p < delka; p++)
            {
                for (int por = 1; por < delka; por++)
                {
                    if (pole[p] == tabulka[por])
                    {
                        serazeno[por] = pole[p];
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int q = 1; q < delka; q++)
            {
                Console.WriteLine(serazeno[q]);
            }
            Console.ReadKey();
               

            
        }
    }
}
