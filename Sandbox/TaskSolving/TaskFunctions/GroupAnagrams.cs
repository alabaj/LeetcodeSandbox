namespace Sandbox.TaskSolving.TaskFunctions;

public static class GroupAnagrams
{
    public static IList<IList<string>> Solve(string[] strs)
    {
        var result = new List<IList<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var tempList = new List<string>();
            if (!tempList.Contains(strs[i]) && !Contains(result, strs[i]))
            {
                tempList.Add(strs[i]);
                for (int j = i + 1; j + 1 <= strs.Length; j++)
                {
                    if (IsAnagram(strs[i], strs[j]))
                    {
                        tempList.Add(strs[j]);
                    }
                }
                
                result.Add(tempList);
            }
        }

        return result;
    }

    private static bool IsAnagram(string s, string t)
    {
        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
        {
            return true;
        }

        if (s.Length != t.Length)
        {
            return false;
        }

        int[] charCount = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            charCount[s[i] - 'a']++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            charCount[t[i] - 'a']--;
            if (charCount[t[i] - 'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }

    private static bool Contains(List<IList<string>> strings, string value)
    {
        foreach (var item in strings)
        {
            foreach (var item2 in item)
            {
                if (item2 == value)
                    return true;
            }
        }

        return false;
    }
}
