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

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.Hit += View_Hit;
            this.view.Stand += View_Stand;
        }

        private void View_Hit()
        {

            view.PValue = model.GetV();
            Console.WriteLine("HIIIIIT");
        }

        private void View_Stand()
        {

        }
    }
}
