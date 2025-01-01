namespace Leetcode.Exercices;

public class Exo1
{
    public int[] nums = [3, 2, 4];
    public int target = 6;

    // Input: nums = [2,7,11,15], target = 9
    // Output: [0,1]


    // My rep
    /*public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [0, 0];
    }*/


    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int currentValue = nums[i];
            int x = target - currentValue;
            if (map.ContainsKey(x))
            {
                return [i, map[x]];
            }

            map[currentValue] = i;
        }


        return [0, 0];
    }
}