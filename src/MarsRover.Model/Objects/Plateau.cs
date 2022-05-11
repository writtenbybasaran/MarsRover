using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MarsRover.Model.CommonModels;

namespace MarsRover.Model.Objects
{
    public class Plateau : IMap
    {
        private Size size { get; set; }

        public void SetSize(Size aSize)
        {
            size = aSize;
        }

        public Size GetSize()
        {
            return size;
        }

        public bool IsValid(Point point)
        {
            var isValidX = point.X >= 0 && point.X <= size.Width;
            var isValidY = point.Y >= 0 && point.Y <= size.Height;
            return isValidX && isValidY;
        }
        
    }
}
