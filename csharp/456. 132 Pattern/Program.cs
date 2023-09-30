/*
 456. 132 Pattern
Given an array of n integers nums, a 132 pattern is a subsequence 
of three integers nums[i], nums[j] and nums[k] such that i < j < k and nums[i] < nums[k] < nums[j].

Return true if there is a 132 pattern in nums, otherwise, return false.
 */

namespace _456._132_Pattern;

public class Solution
{
    static void Main()
    {

        int[] intArray = ReadArrayFromTxt("D:\\GitHub\\leetcode\\csharp\\456. 132 Pattern\\data.txt").ToArray();
        Console.WriteLine(Find132pattern(intArray));

        //int[] nums = { -1, 3, 2, 0 };
        //Console.WriteLine(Find132pattern(nums));
        //nums = new[] { 1, 2, 3, 4 };
        //Console.WriteLine(Find132pattern(nums));

        //Console.WriteLine(Find132pattern(new int[] { 1, 2, 4, 5, 2}));
    }
    static public bool Find132pattern(int[] nums)
    {
        Stack<int> stack = new Stack<int>();
        int third = int.MinValue;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] < third) return true;
            while(stack.Count > 0 && stack.Peek() < nums[i])
            {
                third = stack.Pop();
            }
            stack.Push(nums[i]);
        }

        return false;
    }

    static IEnumerable<int> ReadArrayFromTxt(string filePath)
    {
        // Đọc nội dung tệp tin
        string fileContent = File.ReadAllText(filePath);

        // Tách nội dung thành mảng dựa trên dấu phân tách (ví dụ: dấu phẩy)
        char[] separators = new char[] { ',' }; // Dấu phân tách
        string[] stringArray = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        // Chuyển đổi mảng các chuỗi thành mảng số nguyên (hoặc kiểu dữ liệu khác nếu cần)
        int[] intArray = Array.ConvertAll(stringArray, int.Parse);

        return intArray;
    }
}