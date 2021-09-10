using Application.Repository.Interfaces;
using Domain;

namespace Application.Repository.Move
{
    public class StartMoving : HandleMovement
    {
        Coordinates HandleMovement.StartMoving(Movement movement, Coordinates coordinates)
        {
            return movement.move(coordinates);
        }

    }
}