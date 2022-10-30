using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Models
{
    public class Positions
    {
        private List<Position> positions = new();

        public List<Position> GetPosAndColour()
        {
            var posAndColour = new List<Position>();
            string[] colors = { "RED", "GREEN", "BLUE", "ORANGE", "YELLOW", "PURPLE" };
            var usedColors = new List<string>();
            int pos = 0;
            var rand = new Random();
            int index = rand.Next(colors.Length);
            while (true)
            {


                if (!usedColors.Contains(colors[index]))
                {
                    var newPosAndColour = new Position(pos, colors[index]);
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
    }
}
