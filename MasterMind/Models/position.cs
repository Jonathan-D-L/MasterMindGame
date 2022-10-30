using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Models
{
    public class Position
    {
       
        private int _position;
        private string _color;


        public Position(int position, string color)
        {
            _position = position;
            _color = color;

        }
        public int position { get { return _position; } }
        public string color { get { return _color; } }

    }
}
