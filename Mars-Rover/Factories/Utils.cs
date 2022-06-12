using Mars_Rover.Models;
using Mars_Rover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Rover.Factories
{
    public static class Utils
    {
        public static Position GeneratePosition(int x, int y) => new Position { X = x, Y = y };
        public static CompassPoint GetFrom(this CompassPoint point, Direction direction) 
        {
            var arr = Enum.GetValues(typeof(CompassPoint)).Cast<CompassPoint>();
            int q = arr.Count();
            int number = (int)point;
            switch (direction)
            {
                case Direction.Right:
                    number++;
                    break;
                case Direction.Left:
                    number--;
                    break;
                default:
                    throw new NotImplementedException();
            }
            if (number < 0)
                number += q;
            else
                number %= 4;
            return (CompassPoint)Enum.Parse(typeof(CompassPoint), number.ToString());
        }
    }
}
