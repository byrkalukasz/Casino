using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Classes
{
    class Cards
    {
        //Rodzaje kart(2,3,4,5,6,7,8,9,10,J,Q,K,A)
        public int[] ilosc_kart = new int[13] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
        public string[] karty = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public int[] wartosc_kart = new int[13] { 2,3,4,5,6,7,8,9,10,2,3,4,11};
        public Cards()
        {

        }
    }
}
