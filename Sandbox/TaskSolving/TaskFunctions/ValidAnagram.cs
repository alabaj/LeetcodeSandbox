namespace Sandbox.TaskSolving.TaskFunctions;

public static class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        var firstStringSorted = Sort(s);
        var secondStringSorted = Sort(t);
        return firstStringSorted == secondStringSorted;
    }

    private static char[] Sort(string data)
    {
        var dataArray = data.ToArray();
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = i; j < data.Length; j++)
            {
                if (j < i)
                {
                    var temp = dataArray[i];
                    dataArray[i] = dataArray[j];
                    dataArray[j] = temp;
                }
            }
        }

        return dataArray;
    }
}
