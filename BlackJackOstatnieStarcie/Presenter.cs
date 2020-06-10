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
            {
                model.zero();
                model.DealCard();
                model.DealCard();
                model.DealPCCard();
                view.PValue = model.GetHandValue();
                view.CValue = model.PCGetHandValue();
                checkWinner();
            }
        }

        private void checkWinner()
        {
            switch ( model.checkPlayerHand() )
            {
                case 1:
                    MessageBox.Show("Wygrana gracz");
                    model.incrementWins();
                    startGame();
                    break;
                case 2:
                    MessageBox.Show("Wygrana komputer");
                    startGame();
                    break;
                default:
                    switch ( model.checkPCHand() )
                    {
                        case 1:
                            MessageBox.Show("Wygrana komputer");
                            break;
                        case 2:
                            MessageBox.Show("Wygrana gracz");
                            model.incrementWins();
                            startGame();
                            break;
                        default:
                            break;
                    }
                    break;
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
            while (model.PCGetHandValue() < 17)
            {
                View_HitC();
                Console.WriteLine(model.PCGetHandValue());
            }

            model.Compare()

            Console.WriteLine("STAND");

        }
    }
}