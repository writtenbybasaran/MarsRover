using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Common.Exceptions
{
    public class CommandException : Exception
    {
        public CommandException() : base()
        {
        }

        public CommandException(string msg) : base(msg)
        {
        }
    }
}
