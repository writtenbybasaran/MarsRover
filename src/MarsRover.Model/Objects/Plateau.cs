using MarsRover.Model.CommonModels;

namespace MarsRover.Model.Objects
{
    public class Plateau : IMap
    {
        private Size Size { get; set; }

        public void SetSize(Size aSize)
        {
            Size = aSize;
        }

        public Size GetSize()
        {
            return Size;
        }

        public bool IsValid(Point point)
        {
            var isValidX = point.X >= 0 && point.X <= Size.Width;
            var isValidY = point.Y >= 0 && point.Y <= Size.Height;
            return isValidX && isValidY;
        }
        
    }
}
