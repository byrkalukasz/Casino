using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeksasHoldem.Classes;
using _21.Classes;

namespace TeksasHoldem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz grę");
            int game = Convert.ToInt32(Console.ReadLine());
            _21.Classes.GameControler21 gameControler21 = new GameControler21();
            switch(game)
            {
                case 1:
                    GameControler gameControler = new GameControler();
                    gameControler.GameControl();
                    break;
                case 2:
                    gameControler21.Gra();
                    break;
            }
        }
    }
}
