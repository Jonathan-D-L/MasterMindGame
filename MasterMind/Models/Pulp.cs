using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Models
{
    public class Pulp
    {
       
        private int _position;
        private int _colorId;


        public Pulp(int position, int colorId)
        {
            _position = position;
            _colorId = colorId;

        }
        public int position { get { return _position; } }
        public int color { get { return _colorId; } }

    }
}
