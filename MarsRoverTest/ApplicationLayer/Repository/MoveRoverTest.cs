using Application.Repository.Move;
using Domain;
using Domain.Constants;
using Xunit;

namespace MarsRoverTest.ApplicationLayer.Repository
{
    public class MoveRoverTest
    {
        [Fact]
        public void TestScanrio_12N_LMLMLMLMM()
        {
            //Given
            MoveRover moveRover = new MoveRover();
            var _handleMovement = new StartMoving();
            //When
            var result = moveRover.Move(MockData.maxPoints, MockData.startPosition, MockData.movementDirections, _handleMovement);
            //Then
            var expectedCoordinate = new Coordinates { X = 1, Y = 3, directions = Directions.N };
            Assert.NotNull(result);
            Assert.Equal(expectedCoordinate.X, result.X);
            Assert.Equal(expectedCoordinate.Y, result.Y);
            Assert.Equal(expectedCoordinate.directions, result.directions);
        }

        [Fact]
        public void TestScanrio_33E_MRRMMRMRRM()
        {
            //Given
            MoveRover moveRover = new MoveRover();
            var _handleMovement = new StartMoving();
            //When
            var result = moveRover.Move(MockData.maxPoints, MockData.startPosition2, MockData.movementDirections2, _handleMovement);
            //Then
            var expectedCoordinate = new Coordinates { X = 5, Y = 1, directions = Directions.E };
            Assert.NotNull(result);
            Assert.Equal(expectedCoordinate.X, result.X);
            Assert.Equal(expectedCoordinate.Y, result.Y);
            Assert.Equal(expectedCoordinate.directions, result.directions);
        }
    }
}