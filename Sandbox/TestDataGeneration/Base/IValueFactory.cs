namespace Sandbox.TestDataGeneration.Base;

public interface IValueFactory<T>
{
    T GenerateValue();
}
