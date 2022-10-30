using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Models
{
    public class PositionsAndColour
    {
        private List<Pulp> positions = new();
        private List<Pulp> guesses = new();
        public List<Pulp> SetPosAndColour()
        {
            var posAndColour = new List<Pulp>();
            int[] colors = { 0, 1, 2, 3, 4, 5 };
            var usedColors = new List<int>();
            int pos = 0;
            var rand = new Random();
            int index = rand.Next(colors.Length);
            while (true)
            {


                if (!usedColors.Contains(colors[index]))
                {
                    var newPosAndColour = new Pulp(pos, colors[index]);
                    positions.Add(newPosAndColour);
                    usedColors.Add(colors[index]);
                    pos++;
                }
                else
                {
                    index = rand.Next(colors.Length);
                }
                if (positions.Count >= 4)
                {
                    break;
                }
            }
            return positions;
        }
        public int GuessComparer(List<int> guesses)
        {

            //if (guesses.Any(a => positions.Any(b => b.color.Equals(a -1))))
            //{
            var count = guesses.Count(a => positions.Any(b => b.color.Equals(a -1)));
            // 0 1 2 3 4
            if (count == 1)
                return -1;
            if (count == 2)
                return -2;
            if (count == 3)
                return -3;
            if (count == 4)
                return -4;
            return -5;

        }
        public void GetColour(int input)
        {

            if (input == 1)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.Write($"[1] ");
            }
            else if (input == 2)
            {
                Console.ForegroundColor = System.ConsoleColor.Green;
                Console.Write($"[2] ");
            }
            else if (input == 3)
            {
                Console.ForegroundColor = System.ConsoleColor.Blue;
                Console.Write($"[3] ");
            }
            else if (input == 4)
            {
                Console.ForegroundColor = System.ConsoleColor.Magenta;
                Console.Write($"[4] ");
            }
            else if (input == 5)
            {
                Console.ForegroundColor = System.ConsoleColor.Cyan;
                Console.Write($"[5] ");
            }
            else if (input == 6)
            {
                Console.ForegroundColor = System.ConsoleColor.Yellow;
                Console.Write($"[6] ");
            }
            else if (input == -1)
            {
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write($" 1 ");
            }
            else if (input == -2)
            {
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write($" 2 ");
            }
            else if (input == -3)
            {
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write($" 3 ");
            }
            else if (input == -4)
            {
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write($" 4 ");
            }
            else
            {
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write($" 0 ");
            }
        }
        public int AddColour(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else if (input == 2)
            {
                return 2;
            }
            else if (input == 3)
            {
                return 3;
            }
            else if (input == 4)
            {
                return 4;
            }
            else if (input == 5)
            {
                return 5;
            }
            else if (input == 6)
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }
    }
}
