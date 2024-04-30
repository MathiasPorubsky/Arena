using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Nahoda
    {
        private Random random;
        private Random random2;
        private int pocetSten;

        public Nahoda(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
            random2 = new Random();
        }
        public Nahoda() : this(6)
        {
        }
        public int Hod()
        {
            int cislo = random.Next(pocetSten) + 1; // číslo od 1 do 6, kdyz pocetSten = 6
            int znamenko = (random2.Next(1) == 0) ? -1 : 1; // nahodne - + (kdyz padne 0 vezme se -1, jinak 1)
            cislo *= znamenko; // nahodne cislo od -6 do 6 bez nuly
            return cislo;
        }
        public int HodK()
        {
            int cislo = random.Next(pocetSten);
            return cislo;
        }
    }
}