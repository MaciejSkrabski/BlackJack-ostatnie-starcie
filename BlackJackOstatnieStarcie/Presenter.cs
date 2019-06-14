using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackOstatnieStarcie
{
    class Presenter
    {
        IView view;
        Model model;
        Game game;

        public Presenter(IView view, Model model, Game game)
        {
            this.game = new Game();

            this.view = view;
            this.model = model;
            this.view.Hit += View_Hit;
            this.view.Stand += View_Stand;
            startGame();

        }

        public void startGame()
        {
            model.DealCard();
            model.DealCard();
            model.DealPCCard();
            view.PValue = model.GetHandValue();
            view.CValue = model.PCGetHandValue();
            checkWinner();
        }

        private void checkWinner()
        {
            if (model.checkPlayerHand() == 1)
            {
                MessageBox.Show("Wygrana gracz");
                model.incrementWins();
            }
            else if (model.checkPlayerHand() == 2)
            {
                MessageBox.Show("Wygrana komputer");
            }
            else
            {
                if (model.checkPCHand() == 1)
                {
                   MessageBox.Show("Wygrana komputer");
                }
                else if (model.checkPCHand() == 2)
                {
                    MessageBox.Show("Wygrana gracz");
                    model.incrementWins();
                }
            }
        }

        public void View_Hit()
        {
            model.DealCard();
            view.PValue = model.GetHandValue();
            Console.WriteLine("HIT");
            checkWinner();

        }

        public void View_HitC()
        {
            model.DealPCCard();
            view.CValue = model.PCGetHandValue();

            Console.WriteLine("HIT");
            checkWinner();
        }

        public void View_Stand()
        {
            while (model.PCGetHandValue() < model.GetHandValue())
            {
                View_HitC();
                Console.WriteLine(model.PCGetHandValue());
            }
            //game.ChangeStand(true);



            Console.WriteLine("STAND");

        }
    }
}