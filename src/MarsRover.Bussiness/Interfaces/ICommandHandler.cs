
namespace MarsRover.Bussiness.Interfaces
{
    public interface ICommandHandler
    {
        void Build(string command);
        void Execute();
    }
}
