using Domain;
using Domain.Constants;
using System;
using System.Collections.Generic;

namespace MarsRoverTest.ApplicationLayer.Repository
{
    public class MockData
    {
        public static string[] maxPoints = { "5", "5" };

        public static string[] startPosition = { "1", "2", "N" };
        public static string[] startPosition2 = { "3", "3", "E" };


        public static string movementDirections = "LMLMLMLMM";
        public static string movementDirections2 = "MMRMMRMRRM";

        public static Coordinates coordinates()
        {
            return new Coordinates
            {
                X = 1,
                Y = 2,
                directions = Directions.N
            };
        }
        public static List<int> MaxLst => new List<int> { Convert.ToInt32(maxPoints[0]), Convert.ToInt32(maxPoints[1]) };
    }
}