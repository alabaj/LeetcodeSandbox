using System.Security.Cryptography.X509Certificates;

namespace Sandbox.TaskSolving.TaskFunctions;

public static class TopKFrequentElements
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> occurencies = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!occurencies.ContainsKey(nums[i]))
            {
                occurencies.Add(nums[i], 0);
            }

            occurencies[nums[i]]++;
        }

        return occurencies.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}
