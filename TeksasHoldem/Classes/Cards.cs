using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeksasHoldem.Classes
{
    public class Cards
    {
        string Color;
        string Number;
        string Count;

        //Rodzaje kart(2,3,4,5,6,7,8,9,10,J,Q,K,A)
        public int[] ilosc_kart = new int[13] {4,4,4,4,4,4,4,4,4,4,4,4,4};
        public string[] karty = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public string[] color = new string[4] { "Kier", "Pik", "Trefl", "Karo" };
        public int[] color_count = new int[4] { 13, 13, 13, 13 };
        public Cards()
        {

        }
    }
}
