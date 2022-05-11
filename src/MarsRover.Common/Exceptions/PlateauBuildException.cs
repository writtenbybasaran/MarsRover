using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
