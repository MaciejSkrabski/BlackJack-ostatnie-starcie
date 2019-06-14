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
        
        static int[] talia = {2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
        int round = -2;
       
        int handValue = 0;
        int pcHandValue=0;

        public int getRound() { return round; }
        public void zeroRound() { round = -2; }


        public int GetHandValue() { return (handValue); }
        public int PCGetHandValue() { return pcHandValue; }

        public void zeroHandValue() {handValue = 0;}
        public void zeroPCHandValue() { pcHandValue = 0; }
        public void incrementWins() { wins += 1; }
        int getWins() { return wins; }


        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 13);
        }

       
        public int[] getDeck() { return talia; }

        public void DealCard()
        {
            

            handValue = talia[RandomNumber()];

            
            Console.WriteLine("Card dealt");
            if (getRound() !=0 && GetHandValue() > 21)
            {
                zeroHandValue(); zeroPCHandValue(); MessageBox.Show("BUST! You loose");

            }

        }
            
        public void DealPCCard()
        {
            pcHandValue = talia[RandomNumber()];
            Console.WriteLine("Card dealt");
            if (PCGetHandValue() > 21)
            {
                zeroHandValue(); zeroPCHandValue(); MessageBox.Show("BUST! You win");
                incrementWins();

            }

        }

        public Model()
        {
            handValue = 0;
            pcHandValue = 0;
            DealPCCard();
            DealCard();
            DealCard();
            Console.WriteLine("SHUFFLE");
        }       
    }

    class Game
    {
        int viewscore = 0;
        int pcViewScore = 0;
        static Model player;
        static Model computer;

        static bool stand = false;
        public bool getStand() { return stand; }
        
        public void ChangeStand(bool haba) { stand = haba; }

        public Game()
        {
            ChangeStand(false);
            computer = new Model();
            player = new Model();
            computer.zeroPCHandValue();
            player.zeroHandValue();
            if (player.GetHandValue() == 22 && player.getRound() == 0) { player.zeroHandValue(); computer.zeroPCHandValue(); player.incrementWins(); MessageBox.Show("BLACKJACK!");}
            if (stand == true)
            {
                computer.DealPCCard();
                while (computer.PCGetHandValue() < player.GetHandValue()) computer.DealPCCard();
                if (computer.PCGetHandValue() == player.GetHandValue()) { MessageBox.Show("Draw!"); computer.zeroPCHandValue(); player.zeroHandValue(); }
                else if ((computer.PCGetHandValue() > player.GetHandValue()) && (computer.PCGetHandValue() < 22)) { MessageBox.Show("You loose!"); computer.zeroPCHandValue(); player.zeroHandValue(); }
                else {  MessageBox.Show("You win!"); computer.zeroPCHandValue(); player.zeroHandValue(); player.incrementWins(); }
            }
            
        }
    } 
}
