using Domain;

namespace Application.Repository.Interfaces
{
    public interface HandleMovement
    {
        Coordinates StartMoving(Movement movement, Coordinates coordinates);
    }
}