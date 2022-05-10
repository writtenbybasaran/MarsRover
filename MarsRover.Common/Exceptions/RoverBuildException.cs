using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Common.Exceptions
{
    public class RoverBuildException : Exception
    {
        public RoverBuildException() : base()
        {

        }
        public RoverBuildException(string msg) : base(msg)
        {

        }
    }
}
