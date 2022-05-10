using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model.CommonModels
{
    public interface IMap
    {
        void SetSize(Size aSize);
        Size GetSize();
        bool IsValid(Point aPoint);
    }
}
