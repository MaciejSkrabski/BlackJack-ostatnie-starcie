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
        Model AI;

        public Presenter(IView view, Model model, Model AI, Game game)
        {
            this.view = view;
            this.AI = AI;
            this.model = model;
            this.view.Hit += View_Hit;
            this.view.Stand += View_Stand;
        }

        public void View_Hit()
        {
            view.PValue = model.GetV();
            Console.WriteLine("HIIIIIT");

        }

        public void View_HitC()
        {
            view.CValue = AI.GetV();

            Console.WriteLine("HIIIIIT");
        }

        public void View_Stand()
        {

            View_HitC();
            

            Console.WriteLine("STAAAAAAAAND");

        }
    }
}
