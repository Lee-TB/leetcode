/*  169. Majority Element
 *  Given an array nums of size n, return the majority element.
 *  The majority element is the element that appears more than ⌊n / 2⌋ times.
 *  You may assume that the majority element always exists in the array.
 *  Input: nums = [3,2,3] Output: 3
 *  Input: nums = [2,2,1,1,1,2,2] Output: 2
 */
namespace _169._Majority_Element;

internal class Solution
{
    static void Main(string[] args)
    {
        var nums = new int[] { 1, 2, 3 };
        Console.WriteLine(MajorityElement(nums));        
    }


    public static int MajorityElement(int[] nums)
    {
        int? candadate = null;
        int count = 0;
        foreach (var num in nums)
        {
            if (candadate.HasValue && candadate == num)
            {
                count++;
            }
            else if (count == 0)
            {
                candadate = num;
                count = 1;
            }
            else
            {
                count--;
            }
        }
        return (int)candadate;
    }
}