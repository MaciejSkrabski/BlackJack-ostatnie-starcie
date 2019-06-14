using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOstatnieStarcie
{
    class Presenter
    {
        IView view;
        Model model;
        Game game;

        public Presenter(IView view, Model model, Game game)
        {
            //while (true)
            //{
                this.game = new Game();

                this.view = view;
                this.model = model;
                this.view.Hit += View_Hit;
                this.view.Stand += View_Stand;
                view.PValue = model.GetHandValue();
                view.CValue = model.PCGetHandValue();
            //}
        }

        public void View_Hit()
        {
            model.DealCard();
            view.PValue += model.GetHandValue();
            Console.WriteLine("HIT");

        }

        public void View_HitC()
        {
            model.DealPCCard();
            view.CValue += model.PCGetHandValue();

            Console.WriteLine("HIT");
        }

        public void View_Stand()
        {

            View_HitC();
            //game.ChangeStand(true);
            
            

            Console.WriteLine("STAND");

        }
    }
}
