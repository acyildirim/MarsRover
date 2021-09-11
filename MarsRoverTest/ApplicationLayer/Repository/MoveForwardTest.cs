using Application.Repository.Move;
using Domain;
using Domain.Constants;
using Xunit;

namespace MarsRoverTest.ApplicationLayer.Repository
{
    public class MoveForwardTest
    {

        [Fact]
        public void MoveRoverForwardSuccesfully()
        {
            //Given
            var actualCoordinates = MockData.coordinates();
            MoveForward moveForward = new MoveForward(MockData.MaxLst);
            //When
            var result = moveForward.move(actualCoordinates);
            //Then
            Assert.NotNull(result);
            Assert.Equal(result, actualCoordinates);
        }
        [Fact]
        public void MoveRoverForwardFailed()
        {
            var actualCoordinates = new Coordinates { X = 1, Y = 5, directions= Directions.N};
            MoveForward moveForward = new MoveForward(MockData.MaxLst);
            //When
            var result = moveForward.move(actualCoordinates);
            Assert.Null(result);
        }

    }
}