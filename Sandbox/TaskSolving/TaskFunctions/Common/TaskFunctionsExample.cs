namespace Sandbox.TaskSolving.TaskFunctions.Base;

public static class TaskFunctionsExample
{
    public static string ConcatenateStrings(params string[] strings)
    {
        return string.Concat(strings);
    }
}
