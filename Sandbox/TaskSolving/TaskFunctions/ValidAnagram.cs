namespace Sandbox.TaskSolving.TaskFunctions;

public static class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        var firstStringSorted = Sort(s);
        var secondStringSorted = Sort(t);
        return new string(firstStringSorted) == new string(secondStringSorted);
    }

    private static char[] Sort(string data)
    {
        var dataArray = data.ToArray();
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data.Length; j++)
            {
                if (dataArray[j] > dataArray[i])
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
