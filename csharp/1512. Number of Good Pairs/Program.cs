/*  1512. Number of Good Pairs
 *  Given an array of integers nums, return the number of good pairs. A pair (i, j) is called good if nums[i] == nums[j] and i < j.
    Input: nums = [1,2,3,1,1,3] Output: 4
    Input: nums = [1,1,1,1] Output: 6
    Input: nums = [1,2,3] Output: 0
 */
namespace _1512._Number_of_Good_Pairs;

internal class Solution
{
    static void Main(string[] args)
    {
        var nums = new int[] { 1,1,1,1 };
        Console.WriteLine(NumIdenticalPairs(nums));

    }

    public static int NumIdenticalPairs(int[] nums)
    {
        int numberOfGoodPairs = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    numberOfGoodPairs++;
                }
            }
        }
        return numberOfGoodPairs;
    }
}