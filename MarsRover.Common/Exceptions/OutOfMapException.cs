using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
