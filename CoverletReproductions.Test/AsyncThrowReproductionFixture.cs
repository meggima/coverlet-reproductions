using System;
using System.Threading.Tasks;
using Xunit;

namespace CoverletReproductions.Test
{
    public class AsyncThrowReproductionFixture
    {
        [Fact]
        public async Task Execute_ShouldWork_Exception()
        {
            // Arrange
            var sut = new AsyncThrowReproduction();

            // Act
            async Task TestFunc() => await sut.Execute(true);

            // Assert
            await Assert.ThrowsAsync<InvalidOperationException>(TestFunc);
        }

        [Fact]
        public async Task Execute_ShouldWork_NoException()
        {
            // Arrange
            var sut = new AsyncThrowReproduction();

            // Act
            await sut.Execute(false);
        }
    }
}