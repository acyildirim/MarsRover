using Domain;

namespace Application.Repository.Interfaces
{
    public interface IMoveRover
    {
        Coordinates Move(string[] maxPoints, string[] currentLocation, string movement, HandleMovement _handleMovement);
    }
}