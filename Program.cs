using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSTSIL___Ostania_niezerowa_cyfra_silni
{
    class Program
    {
        public static long policzsilnie(int n)
        {
            long wynik = 1;
            for(int i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }
            return wynik;
        }
        static void Main(string[] args)
        {
            long wynik_silni = 0;
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                int w = -1;
                int liczba = int.Parse(Console.ReadLine());
                wynik_silni = policzsilnie(liczba);
                char[] znaczki=new char [wynik_silni.ToString().Length];
                znaczki = wynik_silni.ToString().ToCharArray();
                for(int j = znaczki.Length - 1; j >= 0; j--)
                {
                    int znak = int.Parse(znaczki[j].ToString());
                    if (znak != 0)
                    {
                        w = znak;
                        break;
                    }
                }
               
                Console.WriteLine(w);

            }
            Console.ReadKey();
        }
    }
}
