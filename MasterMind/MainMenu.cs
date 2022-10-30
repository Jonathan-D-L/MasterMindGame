using MasterMind.GameModes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class MainMenu
    {
        public void StartMenu()
        {
            var normalMode = new NormalMode();
            normalMode.PLayNormalMode();
            //string menutext = "";
            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine(menutext);
            //    var choise = Console.ReadKey().KeyChar;
            //    if (choise == '1')
            //    {
            //        var normalMode = new NormalMode();
            //        normalMode.PLayNormalMode();
            //        break;
            //    }
            //    if (choise == '2')
            //    {
            //        break;
            //    }
            //    if (choise == char.ToLower('q'))
            //    {
            //        break;
            //    }
            //}
        }
    }
}
