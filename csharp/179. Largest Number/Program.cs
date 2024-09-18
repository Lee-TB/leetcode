int[] nums = [9, 30, 5, 34, 3];
var sln = new Solution();
var res = sln.LargestNumber(nums);
Console.WriteLine(res);
Console.WriteLine("4".CompareTo("300"));
Console.WriteLine(4.CompareTo(300));
public class Solution
{
    public string LargestNumber(int[] nums)
    {
        string[] numStrings = new string[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            numStrings[i] = nums[i].ToString();
        }
        Array.Sort(numStrings, new Comparison<string>((a, b) => (b + a).CompareTo(a + b)));
        if (numStrings[0] == "0") return "0";
        return string.Join("", numStrings);
    }
}