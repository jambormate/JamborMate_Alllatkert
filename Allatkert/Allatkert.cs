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
        List<TropusiAlllat> tropusiAlllats = new List<TropusiAlllat>();
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
            tropusiAlllats.Add(new TropusiAlllat(5, "Jaguár", "Elíz", 64, "Nőstény"));
        }
        public void Szamolas()
        {
            int ossz = viziAllats.Count + hidegAllats.Count + mediterranAllats.Count + melegAllats.Count + tropusiAlllats.Count;
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
        }
    }
}
