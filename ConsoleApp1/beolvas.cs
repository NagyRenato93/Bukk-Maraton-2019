using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Beolvas
    {
        //prop TAB TAB és kiadja ezt
        //public int MyProperty { get; set; }
        public string Rajtszam { get; set; }
        public string Kategoria { get; set; }
        public string Nev { get; set; }
        public string Ido { get; set; }
        public string Egyesulet { get; set; }
        public int    OraMasodpercben { get; set; }
        public int    PercMasodpercben { get; set; }
        public int    Masodperc { get; set; }

        public Beolvas(string sor)
        {
            string[]            Szetszed = sor.Split(';');
            Rajtszam =          Szetszed[0];
            Kategoria =         Szetszed[1];
            Nev =               Szetszed[2];
            Egyesulet =         Szetszed[3];
            Ido =               Szetszed[4];
            Szetszed =          Ido.Split(':');
            OraMasodpercben =   int.Parse(Szetszed[0]) * 3600;
            PercMasodpercben =  int.Parse(Szetszed[1]) * 60;
            Masodperc =         int.Parse(Szetszed[2]);
        }
    }
}

