using Sandbox.TestDataGeneration.Base;

namespace Sandbox.TestDataGeneration;

public static class TestData
{
    public static T GetTestData<T>(IValueFactory<T> valueFactory)
    {
        return valueFactory.GenerateValue();
    }

    public static T[] GetTestData<T>(IValueFactory<T> valueFactory, int count)
    {
        T[] data = new T[count];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = valueFactory.GenerateValue();
        }

        return data;
    }
}
