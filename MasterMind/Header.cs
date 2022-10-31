using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class Header
    {
        public void ShowHeader()
        {



            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[1] ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"[2] ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"[3] ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"[4] ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"[5] ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"[6] \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------MASTERTMIND------");
        }
    }
}
