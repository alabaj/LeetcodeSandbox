namespace Sandbox.TaskSolving;

public static class TaskSolver
{
    public delegate TResult TaskLogicDelegate<T, TResult>(T param);
    public delegate TResult TaskLogicDelegate<T1, T2, TResult>(T1 param1, T2 param2);
    public delegate TResult TaskLogicDelegate<T1, T2, T3, TResult>(T1 param1, T2 param2, T3 param3);
    
    public static TResult SolveTask<T, TResult>(TaskLogicDelegate<T, TResult> taskLogic, T param)
    {
        TResult result = taskLogic(param);

        return result;
    }

    public static TResult SolveTask<T1, T2, TResult>(TaskLogicDelegate<T1, T2, TResult> taskLogic, T1 param1, T2 param2)
    {
        TResult result = taskLogic(param1, param2);
        return result;
    }

    public static TResult SolveTask<T1, T2, T3, TResult>(TaskLogicDelegate<T1, T2, T3, TResult> taskLogic, T1 param1, T2 param2, T3 param3)
    {
        TResult result = taskLogic(param1, param2, param3);
        return result;
    }
}
