using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOstatnieStarcie
{
    interface IView
    {
        int CValue { get; set; }
        int PValue { get; set; }
        int CLeft { get; set; }
        event Action Hit;
        event Action Stand;
    }
}
