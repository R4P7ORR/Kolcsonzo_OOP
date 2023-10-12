using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolcsonzo_OOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<IKolcsonozheto> katalogus = new List<IKolcsonozheto>();
			Konyv k1 = new Konyv("Jó könyv", "Király író", "AA41-1R56");
			Dvd d1 = new Dvd("Kiváló dvd", 200);
			Ujsag u1 = new Ujsag("Csúcs újság", 2023, 17);
			Konyv k2 = new Konyv("Rövid könyv", "Alacsony író", "TAZ1-74UE");
			Dvd d2 = new Dvd("A leghosszabb dvd", 450);
			Ujsag u2 = new Ujsag("A legjobb újság", 2021, 6);
			katalogus.Add(k1);
			katalogus.Add(d1);
			katalogus.Add(u1);
			katalogus.Add(k2);
			katalogus.Add(d2);
			katalogus.Add(u2);
			foreach (IKolcsonozheto item in katalogus)
			{
				Console.WriteLine(item.MegjelenitendoNev);
				Console.WriteLine(item.MeddigKolcsonozheto + " napig kölcsönözhető");
                Console.WriteLine("------------------");
            }

            Console.WriteLine("\n-\n-\n");

            List<Dvd> dvdk = new List<Dvd>();
			Dvd d3 = new Dvd("Megfelelő dvd", 100);
			Dvd d4 = new Dvd("Kerek dvd", 360);
			Dvd d5 = new Dvd("Derék dvd", 90);
			dvdk.Add(d1);
			dvdk.Add(d2);
			dvdk.Add(d3);
			dvdk.Add(d4);
			dvdk.Add(d5);
			dvdk.Sort();

			foreach (Dvd d in dvdk)
			{
                Console.WriteLine($"{d.MegjelenitendoNev}\n---------------");
            }


			Console.ReadKey();
		}
	}
}
