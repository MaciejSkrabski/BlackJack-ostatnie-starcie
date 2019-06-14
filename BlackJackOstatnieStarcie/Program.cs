using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackOstatnieStarcie
{
    static class Program
    { 
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                IView view = new Form1();
                Model model = new Model();
                Model AI = new Model();
                Game game = new Game();

                Presenter presenter = new Presenter(view, model, game);
            
            Application.Run((Form)view);
            
            }
        
    }
}
