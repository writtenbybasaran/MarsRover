
namespace MarsRover.Model.CommonModels
{
    public interface IMap
    {
        void SetSize(Size aSize);
        Size GetSize();
        bool IsValid(Point aPoint);
    }
}
