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
            string[] colours = { "RED", "GREEN", "BLUE", "ORANGE", "YELLOW", "PURPLE" };
            int pos = 0;
            while (true)
            {

                var rand = new Random();
                int index = rand.Next(colours.Length);

                if (posAndColour.Any(n => n.color.Contains(colours[index])))
                {
                    index = rand.Next(colours.Length);
                }
                else
                {
                    var newPosAndColour = new Position(pos, colours[index]);
                    positions.Add(newPosAndColour);
                    pos++;
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
