using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackOstatnieStarcie
{
    class Model
    {
        static int call = 0;
        static List<int> talia = new List<int>();
        int cardV;
        int handValue;
        static int numOfCards = 0;
        public int getNumOfCards() { return numOfCards; }
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
        public List<int> getDeck() { return talia; }
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
            numOfCards = talia.Count();
            Console.WriteLine("Card dealt");
        }
        public int GetV() { DealCard(talia); return cardV; }
        public Model()
        {
            numOfCards = talia.Count();
            if (call == 0) Shuffle();
            call += 1;
            Console.WriteLine("SHUFFLE");
            
        }       
    }

    class Game
    {
        static Model player;
        static Model computer;
        static bool stand = false;
        public bool getStand() { return stand; }
        
        public void ChangeStand(bool haba) { stand = haba; }

        public Game()
        {
            computer = new Model();
            player = new Model();
            while (player.getNumOfCards() > 0)
            {

                while (getStand() == false)
                {
                    
                    computer.DealCard(player.getDeck());
                    player.DealCard(player.getDeck());
                    player.DealCard(player.getDeck());


                }
            }



        }
    } 
}
