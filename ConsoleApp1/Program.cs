using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   StreamReader sr =    new StreamReader("bukkm2019.txt");
                     string Fejlec =    sr.ReadLine();
          List<Beolvas> Versenyzok =    new List<Beolvas>();
                      int szamlalo =    0;

            while (!sr.EndOfStream)
            {
                if (szamlalo == 1000)
                {
                    break;
                }
                Versenyzok.Add(new Beolvas(sr.ReadLine()));
            }

            //4. Feladat 
            Console.WriteLine($"\n4. Feladat: \nVersenytávot nem teljesitők:{Math.Round(100-(Versenyzok.Count/6.91),3)}%");

            //5. Feladat 
            szamlalo = 0;
            foreach (var item in Versenyzok)
            {
                if (item.Kategoria.Substring(item.Kategoria.Length - 1) == "n")
                {
                    Versenytav versenytav = new Versenytav(item.Rajtszam);
                    szamlalo += versenytav.Tav == "Rövid" ? 1 : 0;

                }
            }
            Console.WriteLine($"\n5. Feladat: \nNői versenyzők száma a rövidtávu versenyen: {szamlalo} fő");

            //6. Feladat

            for (int i = 0; i < Versenyzok.Count; i++)
            {
                if( Versenyzok[i].OraMasodpercben + Versenyzok[i].PercMasodpercben + Versenyzok[i].Masodperc > 6 * 3600)
                {
                    Console.WriteLine("\n6. Feladat: \nVolt ilyen Versenyző!");
                    break;
                }
            }
            // 7. Feladat
            int legjobbIdo = int.MaxValue, index = -1;
            szamlalo = -1;
            foreach (var item in Versenyzok)
            {
                szamlalo++;

                if (item.Kategoria.Contains("ff"))
                {
                    Versenytav versenytav = new Versenytav(item.Rajtszam);
                    if(versenytav.Tav == "Rövid" && legjobbIdo> item.OraMasodpercben + item.PercMasodpercben + item.Masodperc)
                    {
                        legjobbIdo = item.OraMasodpercben + item.PercMasodpercben + item.Masodperc;
                        index = szamlalo;
                    }
                }
            }
            Console.WriteLine($"\n7. Feladat: \nA felnőtt férfi (ff) kategoria gyöztese rövid távon:\n\t Rajtszám: {Versenyzok[index].Rajtszam}  \n\t Név: {Versenyzok[index].Nev} \n\t Egyesület: {Versenyzok[index].Egyesulet} \n\t Idő: {Versenyzok[index].Ido}");
            HashSet <string> FerfiKategoriak = new HashSet<string>();
            foreach (var item in Versenyzok)
            {
                if (item.Kategoria.EndsWith("f"))
                {
                    FerfiKategoriak.Add(item.Kategoria);
                }
            }  
            // 8. Feladat
            Console.WriteLine("\n8. Feladat: \nStatisztika:");
            foreach (var item in FerfiKategoriak)
            {
                szamlalo = 0;
                for (int i = 0; i < Versenyzok.Count; i++)
                {
                    szamlalo += Versenyzok[i].Kategoria == item ? 1 : 0;
                }
                Console.WriteLine( $"\t {item} - {szamlalo} fő");
            }






            Console.ReadKey();
        }
    }
}
