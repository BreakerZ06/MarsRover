using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.ConsoleApp
{
    class Actor : IActor
    {
        Point _location;
        char _direction;
        char[] _input;
        public Actor(Point location, char direction, char[] input)
        {
            _location = location;
            _direction = direction;
            _input = input;
        }
        public string Calculate()
        {
            for (int i = 0; i < _input.Length; i++)
            {
                switch (_input[i])
                {
                    case ((char)Commands.LEFT):
                        TurnLeft(_direction);
                        break;
                    case ((char)Commands.RIGHT):
                        TurnRight(_direction);
                        break;
                    case ((char)Commands.MOVE):
                        Move(_direction);
                        break;
                }
            }
            if (_location.X > Scene.X || _location.Y > Scene.Y)
                return "Error";
            return $"{_location.X} {_location.Y} {_direction}";
        }

        private void TurnLeft(char direction)
        {
            switch (direction)
            {
                case ((char)Direction.NORTH):
                    _direction = 'W';
                    break;
                case ((char)Direction.SOUTH):
                    _direction = 'E';
                    break;
                case ((char)Direction.EAST):
                    _direction = 'N';
                    break;
                case ((char)Direction.WEST):
                    _direction = 'S';
                    break;
            }
        }
        private void TurnRight(char direction)
        {
            switch (direction)
            {
                case ((char)Direction.NORTH):
                    _direction = 'E';
                    break;
                case ((char)Direction.SOUTH):
                    _direction = 'W';
                    break;
                case ((char)Direction.EAST):
                    _direction = 'S';
                    break;
                case ((char)Direction.WEST):
                    _direction = 'N';
                    break;

            }
        }
        private void Move(char _direction)
        {
            switch (_direction)
            {
                case ((char)Direction.NORTH):
                    _location.Y++;
                    break;
                case ((char)Direction.SOUTH):
                    _location.Y--;
                    break;
                case ((char)Direction.EAST):
                    _location.X++;
                    break;
                case ((char)Direction.WEST):
                    _location.X--;
                    break;
            }
        }
    }
}
