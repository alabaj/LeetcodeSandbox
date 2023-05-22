using Sandbox.TestDataGeneration.Base;

namespace Sandbox.TestDataGeneration.RandomValueFactories;

public class RandomDoubleFactory : IValueFactory<double>
{
    private static Random random = new Random();

    public double GenerateValue()
    {
        return random.NextDouble();
    }
}
