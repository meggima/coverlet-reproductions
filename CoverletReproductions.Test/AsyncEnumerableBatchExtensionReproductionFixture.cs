using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CoverletReproductions.Test;

public class AsyncEnumerableBatchExtensionReproductionFixture
{
    [Fact]
    public async Task ExecuteReproduction_UncoveredBranches()
    {
        // Arrange
        var enumerable = AsyncEnumerable.Range(1, 95);

        // Act
        IAsyncEnumerable<IAsyncEnumerable<int>> batches = enumerable.ExecuteReproduction(10);
        await batches.SelectAwait(batch => batch.ToArrayAsync()).ToArrayAsync();

        // Assert
        // no assert
    }
}
