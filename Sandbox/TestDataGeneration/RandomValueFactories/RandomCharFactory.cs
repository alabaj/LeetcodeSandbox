using Sandbox.TestDataGeneration.Base;

namespace Sandbox.TestDataGeneration.RandomValueFactories;

public class RandomCharFactory : IValueFactory<char>
{
    private static Random random = new Random();
    private const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public char GenerateValue()
    {
        return Characters[random.Next(Characters.Length)];
    }
}
