using System.Collections.Generic;
using Application.Exceptions;
using Application.Repository.Interfaces;
using Domain;
using Domain.Constants;

namespace Application.Repository.Move
{
    public class MoveForward : Movement
    {
        public List<int> maxLimit { get; set; }

        public MoveForward(List<int> maxLimit)
        {
            this.maxLimit = maxLimit;
        }


        public Coordinates move(Coordinates coordinates)
        {
            switch (coordinates.directions)
            {
                case Directions.N:
                    if (coordinates.Y >= maxLimit[1])
                        coordinates = CantMoveException.CantMove("Rover cannot move.");
                    else
                        coordinates.Y += 1;
                    break;

                case Directions.E:
                    if (coordinates.X >= maxLimit[0])
                        coordinates = CantMoveException.CantMove("Rover cannot move.");
                    else
                        coordinates.X += 1;
                    break;

                case Directions.S:
                    if (coordinates.Y != 0)
                        coordinates.Y -= 1;
                    else
                        coordinates = CantMoveException.CantMove("Rover cannot move.");
                    break;

                case Directions.W:
                    if (coordinates.X != 0)
                        coordinates.X -= 1;
                    else
                        coordinates = CantMoveException.CantMove("Rover cannot move.");
                    break;
            }
            return coordinates;
        }
    }
}