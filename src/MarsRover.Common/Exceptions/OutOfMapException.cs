using System;

namespace MarsRover.Common.Exceptions
{
    public class OutOfMapException : Exception
    {
        public OutOfMapException() : base()
        {
        }

        public OutOfMapException(string msg) : base(msg)
        {
        }
    }
}
