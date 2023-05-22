using Sandbox.TestDataGeneration.Base;

namespace Sandbox.TestDataGeneration.RandomValueFactories;

public class RandomBoolFactory : IValueFactory<bool>
{
    private static Random random = new Random();

    public bool GenerateValue()
    {
        return random.Next(2) == 0;
    }
}
