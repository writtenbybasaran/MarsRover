using System;

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
