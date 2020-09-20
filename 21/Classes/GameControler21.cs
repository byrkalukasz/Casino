using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Classes
{
    public class GameControler21
    {
        public void Gra()
        {
            //Celem gry jest zdobycie liczby najbliższej 21

            Gracz gracz = new Gracz();
            Game game = new Game();
            Cards cards = new Cards();
            var GameHelper = game.Rozdaj(cards.ilosc_kart, 2);
            gracz.KartyGracza = GameHelper.Item1;
            poczatek:
            Console.Write("Rozdane karty : ");
            PokazKarty(gracz.KartyGracza);
            Console.WriteLine();
            int suma = game.Suma(gracz.KartyGracza);
            if(suma == 0)
            {
                KoniecGry();
            }
            Console.Write("Suma karty to: " + suma);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("1. Aby dobrać, 2 Aby Zakończyć");
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    var GameHelper2 = game.Rozdaj(cards.ilosc_kart, 1);
                    gracz.KartyGracza = gracz.KartyGracza.Concat(GameHelper2.Item1).ToArray();
                    Console.Clear();
                    goto poczatek;
                case 2:
                    KoniecGry();
                    Console.ReadKey();
                    break;
            }
        }
        void KoniecGry()
        {
            Console.WriteLine("Koniec gry");
            Console.ReadKey();
            Console.WriteLine("Czy chcesz zagrać ponownie?");
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Gra();
                    break;
                case 2:
                    Console.ReadKey();
                    break;
            }
            Gra();

        }
        void PokazKarty(string[] karty)
        {
            int i = 0;
            foreach (string element in karty)
            {
                Console.Write(karty[i] + " ");
                i++;
            }
        }

    }
}
