using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Models
{
    public class PositionsAndColour
    {
        private List<Pulp> positions = new();
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
        public int GuessComparer1(List<int> guesses, List<int> pos)
        {


            var count = guesses.Select(a => a -1).ToList().Intersect(positions.Select(b => b.color).ToList()).ToList().Count();
            if (guesses[0] == pos[0])
                count--;
            if (guesses[1] == pos[1])
                count--;
            if (guesses[2] == pos[2])
                count--;
            if (guesses[3] == pos[3])
                count--;

            if (count == 1)
                return -1;
            if (count == 2)
                return -2;
            if (count == 3)
                return -3;
            if (count == 4)
                return -4;
            return 0;
        }
        public int GuessComparer2(List<int> guesses, List<int> pos)
        {
            var count = 0;
            if (guesses[0] == pos[0])
                count++;
            if (guesses[1] == pos[1])
                count++;
            if (guesses[2] == pos[2])
                count++;
            if (guesses[3] == pos[3])
                count++;

            if (count == 1)
                return -5;
            if (count == 2)
                return -6;
            if (count == 3)
                return -7;
            if (count == 4)
                return -8;
            return -9;
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
            else if (input == -5)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.Write($" 1 ");
            }
            else if (input == -6)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.Write($" 2 ");
            }
            else if (input == -7)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.Write($" 3 ");
            }
            else if (input == -8)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.Write($" 4 ");
            }
            else if (input == -9)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.Write($" 0 ");
            }
            else if (input == 0)
            {
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write($" 0 ");
            }
        }
    }
}
