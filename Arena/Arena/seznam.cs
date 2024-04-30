using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Seznam
    {
        private List<Bojovnik> bojovnici = new List<Bojovnik>()
        {
            { new Bojovnik("Poseidon", 10, 7, 100) },
            { new Bojovnik("Herkules",12, 12, 100) },
            { new Bojovnik("Ares", 14, 9, 100) },
            { new Bojovnik("Hades", 13, 5, 100) },
            { new Bojovnik("Zeus", 11, 8, 100) },
        };

        public Bojovnik VyberHracu()
        {
            Nahoda kostka = new Nahoda(bojovnici.Count);
            int random = kostka.HodK();
            return bojovnici[random];
        }



    }
}