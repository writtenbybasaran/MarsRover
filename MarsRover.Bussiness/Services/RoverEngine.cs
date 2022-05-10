using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Bussiness.Interfaces;
using MarsRover.Model.Enums;
using MarsRover.Model.Objects;

namespace MarsRover.Bussiness.Services
{
    public class RoverEngine : IRoverEngine
    {
        public Rover Rover { get; }
        public Plateau Plateau { get; }

        public void Movement(IList<Movement> movements)
        {
            throw new NotImplementedException();
        }
    }
}
