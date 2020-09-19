using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeksasHoldem.Classes;

namespace TeksasHoldem
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc_graczy = 0;
            int i;
            int[] ilosc_kart = new int[13];
            Cards cards = new Cards();
            Game game = new Game();

            Console.WriteLine("Karty dostępne w Grze");
            i = 0;

            foreach (int element in cards.ilosc_kart)
            {
                Console.Write(cards.karty[i] + " w ilości : ");
                Console.WriteLine(cards.ilosc_kart[i]);
                ilosc_kart[i] = cards.ilosc_kart[i];
                i++;
            }
            Console.ReadKey();
            Console.Clear();
            //Console.Write("Podaj ilość graczy(2-8) : ");
            ilosc_graczy = Convert.ToInt32(Console.ReadLine());
            //ToDo: Dodawanie graczy zgodnie z wyborem
            Gracz gracz1 = new Gracz();
            var helper = game.Rozdaj(ilosc_kart);
            gracz1.kartyGracza = helper.Item1;
            cards.ilosc_kart = helper.Item2;
            Gracz gracz2 = new Gracz();
            var helper2 = game.Rozdaj(ilosc_kart);
            gracz2.kartyGracza = helper2.Item1;
            cards.ilosc_kart = helper2.Item2;
            //game.Rozdaj();
            i = 0;
            Console.Write("Karty gracza pierwszego : ");

            foreach (string element in gracz1.kartyGracza)
            {
                Console.Write(gracz1.kartyGracza[i] +" ");
                i++;
            }

            Console.WriteLine();

            i = 0;
            Console.Write("Karty gracza drugiego : ");

            foreach (string element in gracz2.kartyGracza)
            {
                Console.Write(gracz2.kartyGracza[i] + " ");
                i++;
            }

            Console.WriteLine();

            Console.WriteLine("Karty dostępne w Grze");
            i = 0;

            foreach (int element in cards.ilosc_kart)
            {
                Console.Write(cards.karty[i] + " w ilości : ");
                Console.WriteLine(cards.ilosc_kart[i]);
                i++;
            }

            Console.ReadKey();
            
        }
    }
}
