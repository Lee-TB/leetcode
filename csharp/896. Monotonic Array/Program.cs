/* 896. Monotonic Array
An array is monotonic if it is either monotone increasing or monotone decreasing.
An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j]. An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].
Given an integer array nums, return true if the given array is monotonic, or false otherwise.

Example 1: Input: nums = [1,2,2,3] Output: true
Example 2: Input: nums = [6,5,4,4] Output: true
Example 3: Input: nums = [1,3,2] Output: false
 
Constraints:    1 <= nums.length <= 105 -105 <= nums[i] <= 105*/
namespace _896._Monotonic_Array;

public class Solution
{
    static void Main()
    {
        Console.WriteLine(IsMonotonic(new int[] { 11, 11, 9, 4, 3, 3, 3, 1, -1, -1, 3, 3, 3, 5, 5, 5 }));
    }
    public static bool IsMonotonic(int[] nums)
    {
        int state = 0, prevState = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            state = nums[i].CompareTo(nums[i + 1]) != 0 ? nums[i].CompareTo(nums[i + 1]) : state;

            if (state != 0 && (state + prevState == 0))
            {
                return false;
            }

            prevState = state;
        }

        return true;
    }

    // good approach
    public static bool IsMonotonic_GoodApproach(int[] nums)
    {
        bool isIncreasing = true;
        bool isDecreasing = true;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] < nums[i])
            {
                isDecreasing = false;
            }
            else if (nums[i - 1] > nums[i])
            {
                isIncreasing = false;
            }
        }

        return isDecreasing || isIncreasing; // Neither increase nor decrease;

    }
}