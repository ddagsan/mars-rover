using Mars_Rover.Factories;
using Mars_Rover.Interfaces;
using Mars_Rover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover
{
    public class Coordinator
    {
        string _commands;
        IVehicle _vehicle;
        ITopography _topography;
        public Coordinator(ITopography topography, IVehicle vehicle, string commands)
        {
            if (!topography.IsInside(vehicle.CurrentPosition))
                throw new Exception("The vehicle is not inside the field.");
            _commands = commands;
            _vehicle = vehicle;
            _topography = topography;
        }

        public void Start()
        {
            Utils.Message($"Vehicle position is ({_vehicle.CurrentPosition.X}, {_vehicle.CurrentPosition.Y}, {_vehicle.CurrentCompassPoint}) at the beginning (X, Y, CompassPoint).");
            Utils.Message($"Commands are \"{_commands}\".");

            foreach (char command in _commands)
            {
                switch (command)
                {
                    case 'R':
                        _vehicle.TurnRight();
                        break;
                    case 'L':
                        _vehicle.TurnLeft();
                        break;
                    case 'M':
                        if (_topography.IsInside(_vehicle.CalculateForwardPosition()))
                            _vehicle.Forward();
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            Utils.Message($"The last position of the vehicle is ({_vehicle.CurrentPosition.X}, {_vehicle.CurrentPosition.Y}, {_vehicle.CurrentCompassPoint})");
            Utils.Message($"-----------------------");
            Utils.Message($"-----------------------");
            Utils.Message($"-----------------------");
        }
    }
}
