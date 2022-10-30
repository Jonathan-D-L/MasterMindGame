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
            var posC = posAndColour.SetPosAndColour();
            while (true)
            {
                header.ShowHeader();
                var input = Console.ReadKey().KeyChar;
                posAndColour.GetColour(input);
            }
        }
    }
}
