var sln = new Solution();

var rand = new Random();
int randNumber = rand.Next(1000000); // max value = 10^6
int[] nums = new int[10000]; // max length 10^5
for (int i = 0; i < nums.Length; i++)
{
    if (rand.Next(0, 15) == 0)
        randNumber = rand.Next(1000000);
    nums[i] = randNumber;
}
var res = sln.LongestSubarray(nums);
Console.WriteLine(res);
public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int maxValue = 0, streak = 0, longest = 0;
        foreach (var num in nums)
        {
            // start new streak with new value
            if(num > maxValue)
            {
                maxValue = num;
                longest = streak = 0;
            }
            
            if (num == maxValue)
            {
                streak++;                
            } 
            
            // lose streak
            if(num < maxValue) {                
                streak = 0;
            }

            longest = Math.Max(longest, streak);
        }

        return longest;
    }
}