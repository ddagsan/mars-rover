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
            string commands = "MMRMMRMRRM";

            var rect = new Rectangle(Utils.GeneratePosition(5, 5));
            var rover = new Rover(Utils.GeneratePosition(3, 3), CompassPoint.East);
            var coordinator = new Coordinator(rect, rover, commands);
            coordinator.Start();
        }
    }
}
