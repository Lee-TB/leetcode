/*  343. Integer Break
 *  Given an integer n, break it into the sum of k positive integers, where k >= 2, and maximize the product of those integers.
 *  Return the maximum product you can get.
 *  Input: n = 2 Output: 1 Explanation: 2 = 1 + 1, 1 × 1 = 1.
 *  Input: n = 10 Output: 36 Explanation: 10 = 3 + 3 + 4, 3 × 3 × 4 = 36.
 *  Constraints: 
 *      2 <= n <= 58
 */

using System.Reflection;

namespace _343._Integer_Break;

internal class Solution
{
    static void Main(string[] args)
    {        
        Console.WriteLine(IntegerBreak(580));
    }

    public static int IntegerBreak(int n)
    {
        int product, maximumProduct = int.MinValue, remainder;
        for (int k = 2; k <= n; k++)
        {
            product = 1;
            remainder = n % k;
            for (int i = 1; i <= k; i++)
            {
                if (remainder != 0)
                {
                    product *= (n / k) + 1;
                    remainder--;
                }
                else
                    product *= n / k;
            }
            maximumProduct = Math.Max(maximumProduct, product);
        }
        return maximumProduct;
    }
}