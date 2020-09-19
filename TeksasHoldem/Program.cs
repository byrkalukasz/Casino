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
            //ilosc_graczy = Convert.ToInt32(Console.ReadLine());
            //ToDo: Dodawanie graczy zgodnie z wyborem
            Gracz gracz1 = new Gracz();
            var Gracz1Helper = game.Rozdaj(ilosc_kart,2);
            gracz1.kartyGracza = Gracz1Helper.Item1;
            ilosc_kart = Gracz1Helper.Item2;
            Gracz gracz2 = new Gracz();
            var Gracz2Helper = game.Rozdaj(ilosc_kart,2);
            gracz2.kartyGracza = Gracz2Helper.Item1;
            ilosc_kart = Gracz2Helper.Item2;
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

            //Rozdanie 3 kart na początku
            var GameHelper = game.Rozdaj(ilosc_kart, 3);
            Console.Write("Rozdane karty to: ");
            game.poczatek = GameHelper.Item1;

            i = 0;
            foreach (string element in game.poczatek)
            {
                Console.Write(game.poczatek[i] + " ");
                i++;
            }
            var GameHelper2 = game.Rozdaj(ilosc_kart, 1);
            game.drugie_rozdanie = game.poczatek.Concat(GameHelper2.Item1).ToArray();

            Console.WriteLine();

            Console.Write("Rozdane karty to: ");

            i = 0;
            foreach (string element in game.drugie_rozdanie)
            {
                Console.Write(game.drugie_rozdanie[i] + " ");
                i++;
            }

            var GameHelper3 = game.Rozdaj(ilosc_kart, 1);
            game.trezcie_rozdanei = game.drugie_rozdanie.Concat(GameHelper3.Item1).ToArray();

            Console.WriteLine();

            Console.Write("Rozdane karty to: ");

            i = 0;
            foreach (string element in game.trezcie_rozdanei)
            {
                Console.Write(game.trezcie_rozdanei[i] + " ");
                i++;
            }

            Console.ReadKey();
            
        }
    }
}
