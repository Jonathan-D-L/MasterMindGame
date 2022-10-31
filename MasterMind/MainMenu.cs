using MasterMind.GameModes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class MainMenu
    {
        public void StartMenu()
        {
            var header = new Header();
            var normalMode = new NormalMode();
            var howTo = new HowToPlay();
            while (true)
            {
                Console.Clear();
                header.ShowHeader();
                Console.WriteLine("---------PRESS---------\n1 = PLAY\n2 = HOW TO\nQ = QUIT");
                var choise = Console.ReadKey().KeyChar;
                if (choise == '1')
                {
                    normalMode.PLayNormalMode();
                }
                if (choise == '2')
                {
                    howTo.HowTo();
                }
                if (choise == char.ToLower('q'))
                {
                    return;
                }
            }
        }
    }
}
