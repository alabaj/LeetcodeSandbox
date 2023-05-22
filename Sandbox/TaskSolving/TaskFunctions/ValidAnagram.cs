namespace Sandbox.TaskSolving.TaskFunctions;

public static class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var charCount = new int[26];
        foreach (var item in s)
        {
            charCount[item - 'a']++;
        }

        foreach (var item in t)
        {
            charCount[item - 'a']--;
            if (charCount[item - 'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
