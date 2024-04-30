using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Souboj
    {
        private Bojovnik bojovnik1;
        private Bojovnik bojovnik2;
        private int rest;

        public Souboj() 
        {
            Seznam seznam = new Seznam();
            bojovnik1 = seznam.VyberHracu();
            bojovnik2 = seznam.VyberHracu();
            while (bojovnik1 == bojovnik2)
            {
                bojovnik2 = seznam.VyberHracu();
            }

        }
        public void Start()
        {
            Console.WriteLine("Vítej v aréně!");
            Console.WriteLine($"Dnes se utkají {bojovnik1} a {bojovnik2}");
            Console.WriteLine($"\nZačínat bude {bojovnik1 }");
            Console.WriteLine("Zápas může začít....");
            Console.ReadKey(true);
            Console.Clear();

            while (true)
            {
                if (bojovnik1.Hp > 0)
                {
                    Console.WriteLine("*************souboj****************\n");
                    int poskozeni = bojovnik1.Utoc(bojovnik2);
                    HealthBar(bojovnik2.maxHp, bojovnik2.Hp);
                    Console.WriteLine($"\n{bojovnik2} ztratil {poskozeni} životů.");
                    Console.WriteLine($"{bojovnik2} má {bojovnik2.Hp} životů.");
                }
                else
                {
                    Console.WriteLine($"\nZápas vyhrává {bojovnik2}");
                    break;
                }




                if (bojovnik2.Hp > 0)
                {
                    int poskozeni = bojovnik2.Utoc(bojovnik1);
                    HealthBar(bojovnik1.maxHp, bojovnik1.Hp);
                    Console.WriteLine($"\n{bojovnik1} ztratil {poskozeni} životů.");
                    Console.WriteLine($"{bojovnik1} má {bojovnik1.Hp} životů.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\nZápas vyhrává {bojovnik1}");
                    break;
                }

                Thread.Sleep(750);
                Console.Clear();
            }
        }
        public void HealthBar(int maxHp, int Hp)
        {
            //Console.Write("\n[");
            //for (int i = 0; i < Hp / 10; i++)
            //{
            //    Console.Write("#");
            //}

            //for(int i = 0;i < maxHp / 10 - Hp / 10; i++)
            //{
            //    Console.Write(" ");
            //}
            //Console.WriteLine($"]");

            rest = maxHp / 10 - Hp / 10;
            Console.Write("Život: ");
            for (int i = 0; i < Hp / 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(' ');
            }

            for (int i = 0; i < rest; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(' ');
            }


            Console.ResetColor(); 
        }
    }
}
