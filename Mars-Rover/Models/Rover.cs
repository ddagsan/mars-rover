using Mars_Rover.Factories;
using Mars_Rover.Interfaces;
using Mars_Rover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models
{
    public class Rover : IVehicle
    {
        public Position CurrentPosition { get; set; }

        public CompassPoint CurrentCompassPoint { get; set; }

        public Rover(Position vehiclePosition, CompassPoint point)
        {
            CurrentPosition = vehiclePosition;
            CurrentCompassPoint = point;
        }

        public void TurnRight()
        {
            CurrentCompassPoint = CurrentCompassPoint.GetFrom(Direction.Right);
        }

        public void TurnLeft()
        {
            CurrentCompassPoint = CurrentCompassPoint.GetFrom(Direction.Left);
        }

        public void Forward()
        {
            switch (CurrentCompassPoint)
            {
                case CompassPoint.North:
                    CurrentPosition += Utils.GeneratePosition(0, 1);
                    break;
                case CompassPoint.East:
                    CurrentPosition += Utils.GeneratePosition(1, 0);
                    break;
                case CompassPoint.South:
                    CurrentPosition += Utils.GeneratePosition(0, -1);
                    break;
                case CompassPoint.West:
                    CurrentPosition += Utils.GeneratePosition(-1, 0);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void CalculateForward()
        {
            throw new NotImplementedException();
        }
    }
}
