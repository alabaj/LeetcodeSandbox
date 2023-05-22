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
int parameterSets = 2;


for (int i = 0; i < testCount; i++)
{
    var firstString = TestData.GetTestData(randomStringFactory);
    var secondString = TestData.GetTestData(randomStringFactory);
    var result = TaskSolver.SolveTask(ValidAnagram.IsAnagram, firstString, secondString);
    Console.WriteLine($"#{i + 1}: Parameters: [{string.Join(", ", firstString, secondString)}]\n\tResult: {result}");
}
