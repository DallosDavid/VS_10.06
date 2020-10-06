using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_10._06
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.ForegroundColor = ConsoleColor.Cyan;

           Console.WriteLine("CSATA JÁTÉK\n");
            int valasz;
            do
	        {
                Console.WriteLine("Menü\n1. Kezdés\n2. Kilépés\n");
                Console.Write("Menüpont: ");
                valasz = Convert.ToInt32(Console.ReadLine());
                if (valasz != 1 && valasz != 2)
	            {
                    Console.WriteLine("Rossz menüpont");
	            }
                if (valasz == 1)
	            {
                 Console.Write("Add meg a karaktered nevét: ");
                 string nev = Console.ReadLine();
                 Console.WriteLine("\nKlasszok: \n1.Harcos HP: 30 erő: 5 védekezés: 10\n2.Mágus HP: 15 erő: 8 védekezés: 2 \n3.Íjássz HP: 10 erő: 12 védekezés: 5 (2 körig nem sebződik -> távolról lő)");
                 Console.Write("Add meg a klasszod: ");
	              int klassz = Convert.ToInt32(Console.ReadLine());
                }
	        } while (valasz != 2);
            




            Console.ReadLine();
        }
    }
}
