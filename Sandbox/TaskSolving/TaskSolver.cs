namespace Sandbox.TaskSolving;

public static class TaskSolver
{
    public delegate T TaskLogicDelegate<T, P>(P parameters);

    public static T SolveTask<T, P>(TaskLogicDelegate<T, P> taskLogic, P parameters)
    {
        T result = taskLogic(parameters);

        return result;
    }
}
