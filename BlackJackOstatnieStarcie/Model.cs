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
        int wins = 0;
        //static int numOfCards = 0;
        //static int call = 0;
        //static int call = 0;
        static int[] talia = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
        //int cardV;
        int handValue = 0;
        int pcHandValue = 0;
        public int GetHandValue() { return (handValue); }
        public int PCGetHandValue() { return pcHandValue; }

        public int checkPlayerHand()
        {
            if (handValue == 21)
            {
                return 1;
            }
            else if (handValue > 21)
            {
                return 2;

            }
            else
            {
                return 0;
            }
        }
        public int checkPCHand()
        {
            if (pcHandValue == 21)
            {
                return 1;
            }
            else if (pcHandValue > 21)
            {
                return 2;

            }
            else
            {
                return 0;
            }
        }
        //public void changehandvalue() { handValue += cardV; }
        public void zeroHandValue() { handValue = 0; }
        public void zeroPCHandValue() { pcHandValue = 0; }
        public void incrementWins() { wins += 1; }
        int getWins() { return wins; }


        //public int getNumOfCards() { return numOfCards; }

        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 13);
        }


        public int[] getDeck() { return talia; }
        public void DealCard()
        {
            //int r = RandomNumber(0, 3);

            handValue += talia[RandomNumber()];
            // handValue = talia[RandomNumber()];
            Console.WriteLine("Card dealt");

        }
        public void DealPCCard()
        {
            //int r = RandomNumber(0, 3);

            pcHandValue += talia[RandomNumber()];

            //pcHandValue = talia[RandomNumber()];
            Console.WriteLine("Card dealt");

        }


        //public int GetV() { DealCard(); return cardV; }
        public Model()
        {

            // DealPCCard();
            // DealCard();
            // DealCard();
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
            if (player.GetHandValue() == 22) player.incrementWins();



        }
    }
}