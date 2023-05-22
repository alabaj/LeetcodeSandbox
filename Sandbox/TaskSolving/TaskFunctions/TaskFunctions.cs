using System.Text;

namespace Sandbox.TaskSolving.TaskFunctions;

public static class TaskFunctions
{
    public static string ConcatenateStrings(params string[] strings)
    {
        return string.Concat(strings);
    }
}
