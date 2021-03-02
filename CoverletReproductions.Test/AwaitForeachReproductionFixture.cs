using System.Threading.Tasks;
using Xunit;

namespace CoverletReproductions.Test
{
    public class AwaitForeachReproductionFixture
    {
        [Fact]
        public async Task Execute_ShouldWork()
        {
            // Arrange
            var sut = new AwaitForeachReproduction();

            // Act
            int result = await sut.Execute();

            // Assert
            Assert.Equal(4950, result);
        }
    }
}
