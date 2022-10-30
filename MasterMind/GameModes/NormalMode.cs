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

            var posAndColour = new PositionsAndColour();
            var header = new Header();
            var showBoard = new List<int> { 1, 2, 3 };
            var posC = posAndColour.SetPosAndColour();
            while (true)
            {
                Console.Clear();
                header.ShowHeader();
                int i = 0;
                foreach (var p in showBoard)
                {
                    posAndColour.GetColour(p);
                    i++;
                    if (i == 4)
                    {
                        Console.WriteLine("\n");
                        i = 0;
                    }
                }
                while (true)
                {
                    var input = Console.ReadKey().KeyChar;
                    if ("123456".Contains(input))
                    {
                        int.TryParse(input.ToString(), out int inputInt);
                        posAndColour.GetColour(inputInt);
                        showBoard.Add(inputInt);
                        posAndColour.GetColour(input);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
