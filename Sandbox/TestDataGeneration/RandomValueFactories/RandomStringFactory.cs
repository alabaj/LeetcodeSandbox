using Sandbox.TestDataGeneration.Base;

namespace Sandbox.TestDataGeneration.RandomValueFactories;

public class RandomStringFactory : IValueFactory<string>
{
    private const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static readonly Random random = new Random();

    public string GenerateValue()
    {
        int length = random.Next(1, 10); // Adjust the length range as needed
        char[] stringChars = new char[length];
        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = Characters[random.Next(Characters.Length)];
        }

        return new string(stringChars);
    }
}
