using MasterMind.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.GameModes
{
    internal class NormalMode
    {
        public void PLayNormalMode()
        {

            var posAndColour = new PositionsAndColour();
            var header = new Header();
            var showBoard = new List<int>();
            var guesses = new List<int>();
            var posC = posAndColour.SetPosAndColour();
            while (true)
            {
                Console.Clear();
                header.ShowHeader();
                foreach (var answer in posC)
                    Console.Write($"{answer.color +1} ");
                Console.WriteLine();
                int i = 0;
                if (guesses.Count() == 4)
                {
                    var wGuess = posAndColour.GuessComparer(guesses);
                    Console.ForegroundColor = System.ConsoleColor.White;
                    showBoard.Add(wGuess);
                    //Console.Write($"{wGuess} ");

                }
                foreach (var p in showBoard)
                {
                    posAndColour.GetColour(p);
                    i++;
                    if (i == 5)
                    {
                        Console.Write($"\n");
                        i = 0;
                    }
                }
                if (guesses.Count() == 4)
                {
                    guesses.Clear();
                }
                while (true)
                {
                    var input = Console.ReadKey().KeyChar;
                    if ("123456".Contains(input))
                    {
                        int.TryParse(input.ToString(), out int inputInt);
                        posAndColour.GetColour(inputInt);
                        guesses.Add(inputInt);
                        showBoard.Add(inputInt);
                        posAndColour.GetColour(input);
                        break;
                    }
                }
            }
        }
    }
}
