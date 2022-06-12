using Mars_Rover.Models;
using Mars_Rover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Interfaces
{
    public interface IVehicle
    {
        Position CurrentPosition { get; set; }
        CompassPoint CurrentCompassPoint { get; set; }
        void TurnRight();
        void TurnLeft();
        void Forward();
    }
}
