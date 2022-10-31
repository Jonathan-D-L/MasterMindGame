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
            var playAgain = new playAgain();
            var header = new Header();
            var showBoard = new List<int>();
            var guesses = new List<int>();
            var pos = new List<int>();
            var guessCorrect = 0;
            bool quitNow = false;
            var posC = posAndColour.SetPosAndColour();
            foreach (var p in posC)
            {
                pos.Add(p.color +1);
            }
            while (true)
            {
                if (showBoard.Count >= 60)
                {
                    bool win = false;
                    playAgain.ShowPLayAgain(win, posC);
                    break;
                }
                Console.Clear();
                Console.ForegroundColor = System.ConsoleColor.White;
                header.ShowHeader();
                //
                foreach (var answer in posC)
                    Console.Write($"{answer.color +1} ");
                Console.WriteLine();
                //
                int i = 0;
                if (guesses.Count() == 4)
                {
                    var guess1 = posAndColour.GuessComparer1(guesses, pos);
                    showBoard.Add(guess1);
                    var guess2 = posAndColour.GuessComparer2(guesses, pos);
                    guessCorrect = guess2;
                    showBoard.Add(guess2);
                    if (guessCorrect == -8)
                    {
                        bool win = true;
                        playAgain.ShowPLayAgain(win, posC);
                        break;
                    }
                }
                foreach (var p in showBoard)
                {
                    posAndColour.GetColour(p);
                    i++;
                    if (i == 6)
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
                    if (input == (char)8)
                    {
                        if (guesses.Count != 0)
                        {
                            Console.Write("\a \b");
                            guesses.RemoveAt(guesses.Count -1);
                            showBoard.RemoveAt(showBoard.Count -1);
                            break;
                        }
                    }
                    if (input == 'q')
                    {
                        while (true)
                        {

                            Console.Clear();
                            Console.ForegroundColor = System.ConsoleColor.White;
                            header.ShowHeader();
                            Console.WriteLine("-[QUIT] Are you sure?--\n---------[Y/N]---------");
                            var choise = Console.ReadKey().KeyChar;
                            if (choise == 'y')
                            {
                                quitNow = true;
                                break;
                            }
                            if (choise == 'n')
                            {
                                break;
                            }
                        }
                    }
                    break;
                }
                if (quitNow == true)
                {
                    break;
                }
            }
        }
    }
}

