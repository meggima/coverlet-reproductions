using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoverletReproductions;

public class AwaitForeachReproduction2
{
    public virtual async Task Execute<T>(IAsyncEnumerable<int> messages)
    {
        await foreach (int obj in messages)
        {
            await Task.Delay(1);
        }
    }
}
