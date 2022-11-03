using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point
    {
        private readonly int _x;

        private readonly int _y;

        private readonly string _name;
        public int X => _x;
        public int Y => _y;
        public string Name => _name;

        public Point(int x, int y, string name)
        {
            this._x = x;
            this._y = y;
            this._name = name;
        }
    }
}
