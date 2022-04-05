using System;

namespace MarsRovers
{
    public class Rover
    {
        private Point _position;
        private string _direction;

        internal void SetPosition(Point position)
        {
            _position = position;
        }

        internal Point GetPosition()
        {
            return _position;
        }

        internal void SetDirection(string direction)
        {
            _direction = direction;
        }

        internal string GetDirection()
        {
            return _direction;
        }

        internal void Move()
        {
            switch (_direction)
            {
                case "N":
                    _position = new Point(_position.X, _position.Y + 1);
                    break;
                case "S":
                    _position = new Point(_position.X, _position.Y - 1);
                    break;
                case "E":
                    _position = new Point(_position.X + 1, _position.Y);
                    break;
                case "W":
                    _position = new Point(_position.X - 1, _position.Y);
                    break;


            }
        }

        public void TurnLeft()
        {
            switch (_direction)
            {
                case "N":
                    _direction = "W";
                    break;
                case "S":
                    _direction = "E";
                    break;
                case "E":
                    _direction = "N";
                    break;
                case "W":
                    _direction = "S";
                    break;

            }
        }

        public void TurnRight()
        {
            switch (_direction)
            {
                case "N":
                    _direction = "E";
                    break;
                case "S":
                    _direction = "W";
                    break;
                case "E":
                    _direction = "S";
                    break;
                case "W":
                    _direction = "N";
                    break;

            }
        }
    }
}