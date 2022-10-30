using MasterMind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.GameModes
{
    internal class NormalMode
    {
        public void PLayNormalMode()
        {
            //var Red = Console.ForegroundColor = ConsoleColor.Red;
            //var Green = Console.ForegroundColor = ConsoleColor.Green;
            //var Blue = Console.ForegroundColor = ConsoleColor.Blue;
            //var purple = Console.ForegroundColor = ConsoleColor.Magenta;
            //var cyan = Console.ForegroundColor = ConsoleColor.Cyan;
            //var yellow = Console.ForegroundColor = ConsoleColor.Yellow;

            var posAndColour = new PositionsAndColour();
            var posC = posAndColour.GetPosAndColour();
            while (true)
            {
                foreach (var a in posC)
                {
                    if (a.color == "RED")
                    {
                        Console.ForegroundColor = System.ConsoleColor.Red;
                        Console.Write($"[O] ");
                    }
                    if (a.color == "GREEN")
                    {
                        Console.ForegroundColor = System.ConsoleColor.Green;
                        Console.Write($"[O] ");
                    }
                    if (a.color == "BLUE")
                    {
                        Console.ForegroundColor = System.ConsoleColor.Blue;
                        Console.Write($"[O] ");
                    }
                    if (a.color == "PURPLE")
                    {
                        Console.ForegroundColor = System.ConsoleColor.Magenta;
                        Console.Write($"[O] ");
                    }
                    if (a.color == "CYAN")
                    {
                        Console.ForegroundColor = System.ConsoleColor.Cyan;
                        Console.Write($"[O] ");
                    }
                    if (a.color == "YELLOW")
                    {
                        Console.ForegroundColor = System.ConsoleColor.Yellow;
                        Console.Write($"[O] ");
                    }
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
