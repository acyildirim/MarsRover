
using Application.Repository.Move;
using Domain;
using Domain.Constants;
using Xunit;

namespace MarsRoverTest.ApplicationLayer.Repository
{
    public class MoveLeftTest
    {
        [Fact]
        public void MoveLeftSuccesfully()
        {
        //Given
            var actualCoordinates = MockData.coordinates();
            MoveLeft moveLeft = new MoveLeft();
            //When
            Assert.Equal(Directions.N, actualCoordinates.directions);
            var result = moveLeft.move(actualCoordinates);
            Assert.Equal(Directions.W,result.directions);
        //Then
            Assert.NotNull(result);
            Assert.Equal(result, actualCoordinates);
        }
    }
}