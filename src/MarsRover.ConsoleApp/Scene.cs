using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp
{
    static class Scene
    {
        static Point _grid;

        public static int X { get => _grid.X; }
        public static int Y { get => _grid.Y; }

        public static void Init(int x, int y)
        {
            _grid.X = x;
            _grid.Y = y;
        }
    }
}
