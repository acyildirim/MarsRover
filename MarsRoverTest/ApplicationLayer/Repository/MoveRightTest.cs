using Application.Repository.Move;
using Domain;
using Domain.Constants;
using Xunit;

namespace MarsRoverTest.ApplicationLayer.Repository
{
    public class MoveRightTest
    {
        [Fact]
        public void MoveRightSuccesfully()
        {
            //Given
            var actualCoordinates = MockData.coordinates();
            MoveRight moveLeft = new MoveRight();
            //When
            Assert.Equal(Directions.N, actualCoordinates.directions);
            var result = moveLeft.move(actualCoordinates);
            Assert.Equal(Directions.E, result.directions);
            //Then
            Assert.NotNull(result);
            Assert.Equal(result, actualCoordinates);
        }
    }
}