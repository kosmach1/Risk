using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Igrac
    {
        public string Ime { get; }
        public Color Boja { get; }
        public int Vojnici { get; set; }
        public int brDodadiVojnik { get; set; }
        public bool isTurn { get; set; }
        public int BrojTeritorii { get; set; }
        public bool pomestiEdnas { get; set; }
        public List<Zemja> KontroliraniTeritorii;
        public GameMode Misija { get; set; }

        public Igrac(string Ime, Color Boja)
        {
            this.Ime = Ime;
            this.Boja = Boja;
            this.isTurn = false;
            pomestiEdnas = false;
            this.Vojnici = 0;
            brDodadiVojnik = 0;
            BrojTeritorii = 0;
            KontroliraniTeritorii = new List<Zemja>();
        }

        public void addKontroliraniTeritorii(Zemja ter)
        {
            if(ter != null)
            {
                KontroliraniTeritorii.Add(ter);
            }
        }

        public void izbrisiKontroliranaTeritorija(Zemja ter)
        {
            if(ter != null)
            {
                KontroliraniTeritorii.Remove(ter);
            }
        }

        public int brojVojnicikontrolTerr()
        {
            int n = 0;
            foreach(Zemja z in KontroliraniTeritorii)
            {
                n += z.Vojnici;
            }
            return n;
        }

        public bool daliPobediv()
        {
            if(BrojTeritorii == 42)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Ime;
        }
    }
}
