using System.Threading.Tasks;
using Xunit;

namespace CoverletReproductions.Test
{
    public class AwaitUsingReproductionFixture
    {
        [Fact]
        public async Task Execute_ShouldWork()
        {
            // Arrange
            var sut = new AwaitUsingReproduction();

            // Act
            await sut.Execute();

            // Assert
            // No assert
        }
    }
}
