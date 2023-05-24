using Sandbox.TestDataGeneration.Base;

namespace Sandbox.TestDataGeneration.RandomValueFactories;

public class RandomIntegerFactory : IValueFactory<int>
{
    private static Random random = new Random();

    public int GenerateValue()
    {
        return random.Next(1, 100);
    }

    public int GenerateValue(int min, int max)
    {
        return random.Next(min, max);
    }
}
