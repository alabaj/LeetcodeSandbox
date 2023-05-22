using Sandbox.TaskSolving;
using Sandbox.TaskSolving.TaskFunctions;
using Sandbox.TestDataGeneration.RandomValueFactories;
using System.Text;

#region Value factories
RandomIntegerFactory randomIntegerFactory = new RandomIntegerFactory();
RandomStringFactory randomStringFactory = new RandomStringFactory();
RandomBoolFactory randomBoolFactory = new RandomBoolFactory();
RandomDoubleFactory randomDoubleFactory = new RandomDoubleFactory();
RandomCharFactory randomCharFactory = new RandomCharFactory();
#endregion

int testCount = 3;
int parameterSets = 2;


for (int i = 0; i < testCount; i++)
{
    var nums = new int[] { 3, 2, 4 };
    var target = 6;
    var result = TaskSolver.SolveTask(TwoSum.Solve, nums, target);
    Console.WriteLine($"#{i + 1}: Parameters: {FormatArray(nums, target)}\n\tResult: {FormatArray(result)}");
}

#region Output formatting
string FormatArray(params object[] values)
{
    StringBuilder builder = new StringBuilder();

    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] is Array array)
        {
            builder.Append("[");
            builder.Append(string.Join(", ", GetArrayValues(array)));
            builder.Append("]");
        }
        else
        {
            builder.Append(values[i]);
        }

        if (i < values.Length - 1)
        {
            builder.Append(", ");
        }
    }

    return builder.ToString();
}

string[] GetArrayValues(Array array)
{
    string[] stringValues = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        stringValues[i] = array.GetValue(i)?.ToString()!;
    }

    return stringValues;
}
#endregion