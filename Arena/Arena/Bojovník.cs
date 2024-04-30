using System.Net.Http.Headers;

namespace Arena
{
    internal class Bojovnik
    {
        private string jmeno;
        private int obrana;
        private int utok;
        private int hp;
        public int maxHp;
        private Nahoda kostka = new Nahoda();


        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if (hp <0)
                {
                    hp = 0;
                }
            }
        }

        public Bojovnik(string jmeno, int obrana, int utok, int hp)
        {
            this.jmeno = jmeno;
            this.obrana = obrana;
            this.utok = utok;
            this.hp = hp;
            this.maxHp = hp;
        }
        public int Utoc(Bojovnik souper)
        {
            int uder = utok + kostka.Hod();
            return souper.Block(uder);
        }
        public int Block(int uder)
        {
            int poskozeni = uder + (obrana + kostka.Hod());

            Hp = Hp - poskozeni;
            return poskozeni;
        }
        public override string ToString()
        {
            return jmeno;
        }
    }
}