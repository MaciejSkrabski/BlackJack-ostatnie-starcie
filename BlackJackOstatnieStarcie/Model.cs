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
        Random random = new Random();
        static int[] deck = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

        int handValue = 0;
        int pcHandValue = 0;
        public int GetHandValue() { return (handValue); }
        public int PCGetHandValue() { return pcHandValue; }

        public int checkPlayerHand()
        {
            if (handValue == 21) return 1;
            else if (handValue > 21) return 2;
            return 0;
        }
        public int checkPCHand()
        {
            if (pcHandValue == 21) return 1;
            else if (pcHandValue > 21) return 2;
            return 0;
        }

        public void zero()
        {
            handValue = 0;
            pcHandValue = 0;
        }
        public void zeroPCHandValue() { pcHandValue = 0; }
        public void incrementWins() { wins += 1; }
        int getWins() { return wins; }
        public int[] getDeck() { return deck; }

        public int RandomNumber()
        {
            return random.Next(0, 13);
        }

        public void DealCard()
        {
            handValue += deck[RandomNumber()];
            Console.WriteLine("Card dealt");
        }

        public void DealPCCard()
        {
            pcHandValue += deck[RandomNumber()];
            Console.WriteLine("Card dealt");
        }

        public int Compare() {
            if (handValue > pcHandValue) return 1;
            else if (handValue > pcHandValue) return 2;
            return 0; }

        public Model()
        {
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

        public void StartGame()
        {
            model.zero();
            model.DealCard();
            model.DealCard();
            model.DealPCCard();
            view.PValue = model.GetHandValue();
            view.CValue = model.PCGetHandValue();
            checkWinner();
        }

        public Game()
        {
            if (player.GetHandValue() == 22) player.incrementWins();
        }
    }
}