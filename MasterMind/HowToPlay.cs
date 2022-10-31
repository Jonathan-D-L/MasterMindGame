using MasterMind.GameModes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class HowToPlay
    {
        public void HowTo()
        {
            var header = new Header();
            while (true)
            {
                Console.Clear();
                header.ShowHeader();
                Console.WriteLine("---------PRESS---------\n1-6       => guess" +
                                                         "\nBackspace => undo guess" +
                                                         "\nQ         => quit");
                var input = Console.ReadKey().KeyChar;
                if (input == 'q') break;
            }
        }
    }
}
