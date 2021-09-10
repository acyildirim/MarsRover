using Domain;
using Domain.Constants;
using Application.Repository.Interfaces;

namespace Application.Repository.Move
{
    public class MoveRight : Movement
    {
        public Coordinates move(Coordinates coordinates)
        {
            switch (coordinates.directions)
            {
                case Directions.N:
                    coordinates.directions = Directions.E;
                    break;
                case Directions.E:
                    coordinates.directions = Directions.S;
                    break;
                case Directions.S:
                    coordinates.directions = Directions.W;
                    break;
                case Directions.W:
                    coordinates.directions = Directions.N;
                    break;
            }
            return coordinates;
        }
    }
}