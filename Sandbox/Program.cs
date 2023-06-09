﻿using Sandbox.TaskSolving;
using Sandbox.TaskSolving.TaskFunctions;
using Sandbox.TestDataGeneration;
using Sandbox.TestDataGeneration.RandomValueFactories;
using System.Text;

#region Value factories
RandomIntegerFactory randomIntegerFactory = new RandomIntegerFactory();
RandomStringFactory randomStringFactory = new RandomStringFactory();
RandomBoolFactory randomBoolFactory = new RandomBoolFactory();
RandomDoubleFactory randomDoubleFactory = new RandomDoubleFactory();
RandomCharFactory randomCharFactory = new RandomCharFactory();
#endregion

int testCount = 1;
int parameterSets = 10;


for (int i = 0; i < testCount; i++)
{
    var ints = new int[] {1, 1, 1, 2, 2, 3};
    var k = 2;
    var result = TaskSolver.SolveTask(TopKFrequentElements.TopKFrequent, ints, k);
    Console.WriteLine($"#{i + 1}: Parameters: {FormatMultipleValues(ints, k)}\n\tResult: {FormatMultipleValues(result)}");
}

#region Output formatting
string FormatMultipleValues(params object[] values)
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
        else if (values[i] is IList<IList<string>> nestedList)
        {
            builder.Append("[");
            for (int j = 0; j < nestedList.Count; j++)
            {
                builder.Append("[");
                builder.Append(string.Join(", ", nestedList[j]));
                builder.Append("]");

                if (j < nestedList.Count - 1)
                {
                    builder.Append(", ");
                }
            }
            builder.Append("]");
        }
        else if (values[i] is IList<string> list)
        {
            builder.Append("[");
            builder.Append(string.Join(", ", list));
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

//string[] GetEnumerableValues(IEnumerable enumerable)
//{
//    List<string> stringValues = new List<string>();

//    foreach (var item in enumerable)
//    {
//        stringValues.Add(item?.ToString() ?? string.Empty);
//    }

//    return stringValues.ToArray();
//}
#endregion