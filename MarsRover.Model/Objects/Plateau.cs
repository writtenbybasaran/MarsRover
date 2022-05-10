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

        public bool IsValid(Point aPoint)
        {
            var isValidX = aPoint.X >= 0 && aPoint.X <= size.Width;
            var isValidY = aPoint.Y >= 0 && aPoint.Y <= size.Height;
            return isValidX && isValidY;
        }
        
    }
}
