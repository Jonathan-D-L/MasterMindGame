using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.GameModes
{
    internal class Header
    {
        public void ShowHeader()
        {
            Console.Clear();
            Console.WriteLine("------MASTERTMIND------");

            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.Write($"[1] ");

            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write($"[2] ");

            Console.ForegroundColor = System.ConsoleColor.Blue;
            Console.Write($"[3] ");

            Console.ForegroundColor = System.ConsoleColor.Magenta;
            Console.Write($"[4] ");

            Console.ForegroundColor = System.ConsoleColor.Cyan;
            Console.Write($"[5] ");

            Console.ForegroundColor = System.ConsoleColor.Yellow;
            Console.Write($"[6] \n\n");
            Console.ForegroundColor = System.ConsoleColor.White;
            var board = new string[] { "[0]", "[0]", "[0]", "[0]" };
            foreach (string line in board)
            {
                if (line.Contains('1'))
                {
                    Console.ForegroundColor = System.ConsoleColor.Red;
                    Console.Write($" {line} ");
                    Console.ForegroundColor = System.ConsoleColor.White;
                }
                if (line.Contains('2'))
                {
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    Console.Write($" {line} ");
                    Console.ForegroundColor = System.ConsoleColor.White;
                }
                if (line.Contains('3'))
                {
                    Console.ForegroundColor = System.ConsoleColor.Blue;
                    Console.Write($" {line} ");
                    Console.ForegroundColor = System.ConsoleColor.White;
                }
                if (line.Contains('4'))
                {
                    Console.ForegroundColor = System.ConsoleColor.Magenta;
                    Console.Write($" {line} ");
                    Console.ForegroundColor = System.ConsoleColor.White;
                }
                if (line.Contains('5'))
                {
                    Console.ForegroundColor = System.ConsoleColor.Cyan;
                    Console.Write($" {line} ");
                    Console.ForegroundColor = System.ConsoleColor.White;
                }
                if (line.Contains('6'))
                {
                    Console.ForegroundColor = System.ConsoleColor.Yellow;
                    Console.Write($" {line} ");
                    Console.ForegroundColor = System.ConsoleColor.White;
                }
                if (line.Contains('0'))
                {
                    Console.Write($" {line} ");
                }
            }
        }
    }
}
