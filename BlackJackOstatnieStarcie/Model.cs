using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOstatnieStarcie
{
    class Model
    {
        static int call = 0;
        static List<int> talia = new List<int>();
        int cardV;


        public void Shuffle()
        {
            talia.Add(11); talia.Add(11); talia.Add(11); talia.Add(11);

            talia.Add(1); talia.Add(1); talia.Add(1); talia.Add(1);

            talia.Add(2); talia.Add(2); talia.Add(2); talia.Add(2);

            talia.Add(3); talia.Add(3); talia.Add(3); talia.Add(3);

            talia.Add(4); talia.Add(4); talia.Add(4); talia.Add(4);

            talia.Add(5); talia.Add(5); talia.Add(5); talia.Add(5);

            talia.Add(6); talia.Add(6); talia.Add(6); talia.Add(6);

            talia.Add(7); talia.Add(7); talia.Add(7); talia.Add(7);

            talia.Add(8); talia.Add(8); talia.Add(8); talia.Add(8);

            talia.Add(9); talia.Add(9); talia.Add(9); talia.Add(9);

            talia.Add(10); talia.Add(10); talia.Add(10); talia.Add(10);

            talia.Add(10); talia.Add(10); talia.Add(10); talia.Add(10);

            talia.Add(10); talia.Add(10); talia.Add(10); talia.Add(10);

            talia.Add(10); talia.Add(10); talia.Add(10); talia.Add(10);
        }

        public void DealCard(List<int> t)
        {
            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            int r = RandomNumber(0, t.Count);

            cardV = t.ElementAt(r);
            talia.RemoveAt(r);
            Console.WriteLine("SHUFFLE");
        }

        public int GetV() { DealCard(talia); return cardV; }

        public Model()
        {
            if (call == 0) Shuffle();
            call += 1;

        // DealCard(talia);

            Console.WriteLine("Sukces");

        }

        
    }
}
