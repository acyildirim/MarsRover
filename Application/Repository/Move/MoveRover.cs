using System;
using System.Collections.Generic;
using Application.Core;
using Application.Repository.Interfaces;
using AutoMapper;
using Domain;
using Domain.Constants;


namespace Application.Repository.Move
{
    public class MoveRover : IMoveRover
    {
       
        public Coordinates Move(string[] maxPoints, string[] startPosition, string movementDirections, HandleMovement _handleMovement)
        {

            List<int> maxCoordinates = new List<int>();
            foreach (var point in maxPoints)
            {
                int maxCoordinate = Convert.ToInt32(point);
                maxCoordinates.Add(maxCoordinate);
            }

            Coordinates coordinates = new Coordinates();
            coordinates.X = Convert.ToInt32(startPosition[0]);
            coordinates.Y = Convert.ToInt32(startPosition[1]);
            coordinates.directions = (Directions)Enum.Parse(typeof(Directions), startPosition[2]);
            Movement movement;

            foreach (var direction in movementDirections)
            {
                switch (direction)
                {
                    case 'L':
                        movement = new MoveLeft();
                        break;

                    case 'R':
                        movement = new MoveRight();
                        break;

                    case 'M':
                        movement = new MoveForward(maxCoordinates);
                        break;

                    default:
                        return null;
                }

                Coordinates arrivedCoordinate = _handleMovement.StartMoving(movement, coordinates);
                if (arrivedCoordinate == null)
                    return null;

                coordinates = ObjectMapper.Mapper.Map<Coordinates>(arrivedCoordinate);

            }

            return coordinates;
        }
    }
}