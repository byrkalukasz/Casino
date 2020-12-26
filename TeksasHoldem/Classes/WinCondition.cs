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
            string Winner = null, Winner2 = null;
            int j = 0;

            string Helper;
            Helper = gracz1[0].ToString();
            foreach (string karta in rozdane)
            {
                if (Winner2 == null && Helper == karta)
                {
                    Winner2 = "Para";
                }
                 else if (Winner2 == "Para" && Helper == karta)
                {
                    Winner2 = "Trójka";
                }
                 else if (Winner2 == "Trójka" && Helper == karta)
                {
                    Winner2 = "Czwórka";
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
                else if (Winner2 == "Para" && Helper == karta)
                {
                    Winner = "Dwie pary";
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
