using Mars_Rover.Factories;
using Mars_Rover.Models;
using Mars_Rover.Models.Enums;
using System;

namespace Mars_Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(Utils.GeneratePosition(5, 5));
            var rover1 = new Rover(Utils.GeneratePosition(1, 2), CompassPoint.North);
            var coordinator1 = new Coordinator(rect, rover1, "LMLMLMLMM");
            coordinator1.Start();
            var rover2 = new Rover(Utils.GeneratePosition(3, 3), CompassPoint.East);
            var coordinator2 = new Coordinator(rect, rover2, "MMRMMRMRRM");
            coordinator2.Start();
        }
    }
}
