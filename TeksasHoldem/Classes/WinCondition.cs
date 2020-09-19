using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeksasHoldem.Classes
{
    class WinCondition
    {
        //Para, trojka, czwórka, full,kolor, stait, poker 

        public (string, string) Para(string[] gracz1, string[] rozdane )
        {
            //Para -> Dwie te same karty
            string Winner = null;
            int j = 0;

            string Helper;
            Helper = gracz1[0].ToString();
            foreach (string karta in rozdane)
            {
                if (Winner == null && Helper == karta)
                {
                    Winner = "Para";
                }
                 else if (Winner == "Para" && Helper == karta)
                {
                    Winner = "Trójka";
                }
                 else if (Winner == "Trójka" && Helper == karta)
                {
                    Winner = "Czwórka";
                }
            }

            Helper = gracz1[1].ToString();
            foreach (string karta in rozdane)
            {
                if (Winner == null && Helper == karta)
                {
                    Winner = "Para";
                }
                 else if (Winner == "Para" && Helper == karta)
                {
                    Winner = "Trójka";
                }
                 else if (Winner == "Trójka" && Helper == karta)
                {
                    Winner = "Czwórka";
                }
            }
            if (Winner == null)
                Winner = "Brak";
            return ("Para", Winner);
        }
        public void Trojka()
        {
        }
    }
}
