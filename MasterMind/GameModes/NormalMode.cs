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
            
            var posAndColour = new Positions();
            var posC = posAndColour.GetPosAndColour();
            foreach (var a in posC)
            {
                Console.Write($"[{a.position}-{a.color}]  ");
            }
            
        }
    }
}
