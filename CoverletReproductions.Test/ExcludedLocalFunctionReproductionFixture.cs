using Xunit;

namespace CoverletReproductions.Test;

public class ExcludedLocalFunctionReproductionFixture
{
    [Fact]
    public void Execute_ShouldWork()
    {
        // Arrange
        var sut = new ExcludedLocalFunctionReproduction();

        // Act
        sut.SomethingThatIsUsingALocalFunction();
    }
}
