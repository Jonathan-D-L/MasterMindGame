using MasterMind.GameModes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class playAgain
    {
        public void ShowPLayAgain(bool win)
        {
            Console.ForegroundColor = System.ConsoleColor.White;
            var normalmode = new NormalMode();
            while (true)
            {
                if (win == true)
                {
                    Console.Clear();
                    Console.WriteLine("Grattis du vann spela igen? J/N");
                }
                if (win == false)
                {
                    Console.Clear();
                    Console.WriteLine("Du förlora spela igen? J/N");
                }
                var choise = Console.ReadKey().KeyChar;
                if (choise == 'j')
                {
                    normalmode.PLayNormalMode();
                    break;
                }
                if (choise == 'n')
                {
                    break;
                }
            }
        }
    }
}
