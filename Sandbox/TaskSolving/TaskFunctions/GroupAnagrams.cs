using System.Text;

namespace Sandbox.TaskSolving.TaskFunctions;

public static class GroupAnagrams
{
    public static IList<IList<string>> Solve(string[] strs)
    {
        var dictionary = new Dictionary<string, List<string>>();
        foreach (var item in strs)
        {
            int[] charCount = new int[26];
            foreach (var character in item)
            {
                charCount[character - 'a']++;
            }

            var keyString = ArrayToString(charCount);

            if (dictionary.GetValueOrDefault(keyString) == null)
            {
                dictionary.Add(keyString, new List<string>());
            }

            dictionary[keyString].Add(item);
        }

        var result = new List<IList<string>>();
        foreach (var item in dictionary.Keys)
        {
            result.Add(dictionary[item]);
        }

        return result;
    }

    private static string ArrayToString(int[] array)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sb.Append($"{i + 'a'}{array[i]}");
            }
        }

        return sb.ToString();
    }
}
