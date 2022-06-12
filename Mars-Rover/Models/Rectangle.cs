using Mars_Rover.Factories;
using Mars_Rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models
{
    public class Rectangle : ITopography
    {
        /// <summary>
        /// top-right
        /// </summary>
        Position TR;
        /// <summary>
        /// bottom-left
        /// </summary>
        Position BL;
        public Rectangle(Position topRightPosition)
        {
            TR = topRightPosition;
            BL = Utils.GeneratePosition(0, 0);
        }

        public Rectangle(int x, int y): this(new Position(x, y))
        {
            
        }

        public bool IsInside(int x, int y)
        {
            var pos = new Position { X = x, Y = y };
            return IsInside(pos);
        }

        public bool IsInside(Position position)
        {
            return TR.X >= position.X && BL.X <= position.X && TR.Y >= position.Y && BL.Y <= position.Y;
        }
    }
}
