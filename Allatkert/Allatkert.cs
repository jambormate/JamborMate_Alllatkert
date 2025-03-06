using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert
{
    internal class Allatkert
    {
        List<ViziAllat> viziAllats = new List<ViziAllat>();
        List<HidegAllat> hidegAllats = new List<HidegAllat>();
        List<MediterranAllat> mediterranAllats = new List<MediterranAllat>();
        List<MelegAllat> melegAllats = new List<MelegAllat>();
        List<TropusiAlllat> tropusiAllats = new List<TropusiAlllat>();
        Random rnd = new Random();
        private int capacity = 0;
        private int telitetseg = 0;

        public Allatkert()
        {
            capacity = rnd.Next(5, 16);

        }

        public void Beolvasas()
        {
            viziAllats.Add(new ViziAllat(5, "Fóka", "Ottó", 54, "Hím"));
            hidegAllats.Add(new HidegAllat(6, "Jegesmedve", "Anna", 231, "Nőstény"));
            mediterranAllats.Add(new MediterranAllat(4, "Nyúl", "Oreo", 3, "Hím"));
            melegAllats.Add(new MelegAllat(3, "Teve", "Döme", 457, "Hím"));
            tropusiAllats.Add(new TropusiAlllat(5, "Jaguár", "Elíz", 64, "Nőstény"));
        }
        public void Szamolas()
        {
            int ossz = viziAllats.Count + hidegAllats.Count + mediterranAllats.Count + melegAllats.Count + tropusiAllats.Count;
            telitetseg = ossz;
            for (int i = 0; i < capacity; i++)
            {
                if (i < telitetseg)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public class Allat
        {
            public string Nev { get; set; }
            public int Sebesseg { get; set; }
        }

        public void Verseny()
        {
            List<Allat> allatok = new List<Allat>
            {
                new Allat { Nev = viziAllats[0].Nev, Sebesseg = viziAllats[0].Sebesseg },
                new Allat { Nev = hidegAllats[0].Nev, Sebesseg = hidegAllats[0].Sebesseg },
                new Allat { Nev = mediterranAllats[0].Nev, Sebesseg = mediterranAllats[0].Sebesseg },
                new Allat { Nev = melegAllats[0].Nev, Sebesseg = melegAllats[0].Sebesseg },
                new Allat { Nev = tropusiAllats[0].Nev, Sebesseg = tropusiAllats[0].Sebesseg }
            };
            int haladas = 0;
            int haladas2 = 0;
            int haladas3 = 0;
            int haladas4 = 0;
            int haladas5 = 0;

            Console.WriteLine($"{allatok[0].Nev} O");
            Console.WriteLine($"{allatok[1].Nev} O");
            Console.WriteLine($"{allatok[2].Nev} O");
            Console.WriteLine($"{allatok[3].Nev} O");
            Console.WriteLine($"{allatok[4].Nev} O");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.Clear();

                Console.SetCursorPosition(haladas, 0);
                Console.Write("O");
                haladas += allatok[0].Sebesseg;

                Console.SetCursorPosition(haladas2, 1);
                Console.Write("O");
                haladas2 += allatok[1].Sebesseg;

                Console.SetCursorPosition(haladas3, 2);
                Console.Write("O");
                haladas3 += allatok[2].Sebesseg;

                Console.SetCursorPosition(haladas4, 3);
                Console.Write("O");
                haladas4 += allatok[3].Sebesseg;

                Console.SetCursorPosition(haladas5, 4);
                Console.Write("O");
                haladas5 += allatok[4].Sebesseg;
            }
            //Nem tudtam megoldani hogy a nevek ne törlődjenek, ha ott maradtak akkor vagy követték az O-kat vagy az O-k se törlődtek.
        }
    }
}

