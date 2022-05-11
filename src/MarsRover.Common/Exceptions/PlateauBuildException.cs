using System;

namespace MarsRover.Common.Exceptions
{
    public class PlateauBuildException : Exception
    {
        public PlateauBuildException() : base()
        {

        }
        public PlateauBuildException(string msg) : base(msg)
        {

        }
    }
}
