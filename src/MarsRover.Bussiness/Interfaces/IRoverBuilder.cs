using MarsRover.Model.Objects;

namespace MarsRover.Bussiness.Interfaces
{
    public interface IRoverBuilder
    {
        Rover Build(string arg);
        void SetMovements(Rover rover, string actionList);
    }
}
