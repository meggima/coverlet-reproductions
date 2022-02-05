using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CoverletReproductions.Test;

public class AwaitForeachReproductionFixture2
{
    [Fact]
    public async Task Execute_ShouldWork()
    {
        // Arrange
        var sut = new AwaitForeachReproduction2();

        // Act
        await sut.Execute<object>(RangeAsync(1, 3));
    }

    static async IAsyncEnumerable<int> RangeAsync(int start, int count)
    {
        for (int i = 0; i < count; i++)
        {
            await Task.Delay(i);
            yield return start + i;
        }
    }
}
