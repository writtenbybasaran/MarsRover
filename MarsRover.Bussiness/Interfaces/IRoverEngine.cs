using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Model.Enums;
using MarsRover.Model.Objects;

namespace MarsRover.Bussiness.Interfaces
{
    public interface IRoverEngine
    {
        Rover Rover { get; }
        Plateau Plateau { get; }
        void Movement(IList<Movement> movements);
    }
}
