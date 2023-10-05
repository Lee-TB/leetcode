/*  229. Majority Element II
 *  Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.
    Input: nums = [3,2,3] Output: [3]
    Input: nums = [1] Output: [1]
    Input: nums = [1,2] Output: [1,2]
 */

namespace _229._Majority_Element_II;

internal class Solution
{
    static void Main(string[] args)
    {
        var nums = new int[] { 3, 2, 3};
        foreach (var num in MajorityElement_BestSolution(nums))
        {
            Console.WriteLine(num);
        }
    }

    public static IList<int> MajorityElement_BestSolution(int[] nums)
    {
        List<int> result = new List<int>();
        int? candidate1 = null, candidate2 = null;
        int count1 = 0, count2 = 0;
        foreach (var num in nums)
        {
            if (candidate1.HasValue && num == candidate1)
            {
                count1++;
            }
            else if (candidate2.HasValue && num == candidate2)
            {
                count2++;
            }
            else if (count1 == 0)
            {
                candidate1 = num;
                count1 = 1;
            }
            else if (count2 == 0)
            {
                candidate2 = num;
                count2 = 1;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        count1 = count2 = 0;
        foreach (var num in nums)
        {
            if (num == candidate1) { count1++; }
            if (num == candidate2) { count2++; }
        }
        if (candidate1.HasValue && count1 > nums.Length / 3) result.Add((int)candidate1);
        if (candidate2.HasValue && count2 > nums.Length / 3) result.Add((int)candidate2);

        return result;
    }

    // My First Thought solution
    public IList<int> MajorityElement_MyFirstThought(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map[num] = 1;
            }
        }
        return map.Where(x => x.Value > nums.Length / 3).ToDictionary(x => x.Key, x => x.Value).Keys.ToList();
    }
}