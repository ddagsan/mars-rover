using Mars_Rover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Interfaces
{
    public interface ITopography
    {
        bool IsInside(int x, int y);
        bool IsInside(Position position);
    }
}
