using Sandbox.TaskSolving;
using Sandbox.TaskSolving.TaskFunctions;
using Sandbox.TestDataGeneration;
using Sandbox.TestDataGeneration.RandomValueFactories;

#region Value factories
RandomIntegerFactory randomIntegerFactory = new RandomIntegerFactory();
RandomStringFactory randomStringFactory = new RandomStringFactory();
RandomBoolFactory randomBoolFactory = new RandomBoolFactory();
RandomDoubleFactory randomDoubleFactory = new RandomDoubleFactory();
RandomCharFactory randomCharFactory = new RandomCharFactory();
#endregion

int testCount = 3;
int parameterSets = 5;


for (int i = 0; i < testCount; i++)
{
    var data = TestData.GetTestData(randomStringFactory, parameterSets);
    var result = TaskSolver.SolveTask<string, string[]>(TaskFunctions.ConcatenateStrings, data);
    Console.WriteLine($"#{i + 1}: Parameters: [{string.Join(", ", data)}]\n\tResult: {result}");
}
