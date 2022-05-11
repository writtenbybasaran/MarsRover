using MarsRover.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Bussiness.Interfaces
{
    public interface IRoverBuilder
    {
        Rover Build(string arg);
        void SetMovements(Rover rover, string actionList);
    }
}
