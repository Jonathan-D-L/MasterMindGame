using MasterMind.GameModes;
using MasterMind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class playAgain
    {
        public void ShowPLayAgain(bool win, List<Pulp> posC)
        {
            var posAndColour = new PositionsAndColour();
            var normalmode = new NormalMode();
            var header = new Header();
            while (true)
            {
                if (win == true)
                {
                    Console.Clear();
                    Console.ForegroundColor = System.ConsoleColor.White;
                    header.ShowHeader();
                    Console.Write("Answer: ");
                    foreach (var answer in posC)
                    {
                        posAndColour.GetColour(answer.color +1);
                    }
                    Console.ForegroundColor = System.ConsoleColor.White;
                    Console.WriteLine("\n-You won, play again?--\n---------[Y/N]---------");
                }
                if (win == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = System.ConsoleColor.White;
                    header.ShowHeader();
                    Console.Write("Answer: ");
                    foreach (var answer in posC)
                    {
                        posAndColour.GetColour(answer.color +1);
                    }
                    Console.ForegroundColor = System.ConsoleColor.White;
                    Console.WriteLine("\n-You lost, play again?-\n---------[Y/N]---------");
                }
                var choise = Console.ReadKey().KeyChar;
                if (choise == 'y')
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
