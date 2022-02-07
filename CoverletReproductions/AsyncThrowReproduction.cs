using System;
using System.Threading.Tasks;

namespace CoverletReproductions;

public class AsyncThrowReproduction
{
    public async Task Execute(bool throwException)
    {
        try
        {
            if (throwException)
            {
                throw new InvalidOperationException();
            }
        }
        catch (InvalidOperationException)
        {
            await Task.Delay(1);
            throw;
        }
    }

}
