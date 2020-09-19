﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _21.Classes
{
    class Game
    {
        Cards cards = new Cards();
        public (string[], int[]) Rozdaj(int[] _ilosc_kart, int ile_rozdac)
        {
            string[] karty = new string[ile_rozdac];
            //Ropzdaje dwie losowe kart
            //odejmuje karte z tablicy z iloscia kart
            Random random = new Random();
            int początek = 1;
            int koniec = 13;
            ile_rozdac--;
            for (int i = 0; i <= ile_rozdac; i++)
            {
                int helper;
                Thread.Sleep(1000);
                int wylosowana = random.Next(początek, koniec);
                karty[i] = cards.karty[wylosowana];
                Thread.Sleep(1000);
                helper = Convert.ToInt32(_ilosc_kart[wylosowana].ToString());
                helper--;
                _ilosc_kart[wylosowana] = helper;
            }

            return (karty, _ilosc_kart);

        }
    }
}
