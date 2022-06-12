using Mars_Rover.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models
{
    public class Position : ICloneable
    {
        /// <summary>
        /// Represents x axis
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Represents y axis
        /// </summary>
        public int Y { get; set; }
        public Position()
        {

        }
        public Position(Position pos)
        {
            X = pos.X;
            Y = pos.Y;
        }

        public static Position operator +(Position a, Position b) => Utils.GeneratePosition(a.X + b.X, a.Y + b.Y);

        public object Clone()
        {
            return new Position(this);
        }
    }
}
