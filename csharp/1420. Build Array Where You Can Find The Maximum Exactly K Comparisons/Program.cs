﻿/* https://leetcode.com/problems/build-array-where-you-can-find-the-maximum-exactly-k-comparisons/description/?envType=daily-question&envId=2023-10-07
 */

namespace _1420._Build_Array_Where_You_Can_Find_The_Maximum_Exactly_K_Comparisons;

internal class Solution
{
    static void Main(string[] args)
    {

        Console.WriteLine(NumOfArrays(9, 1, 1));
    }

    public static int NumOfArrays(int n, int m, int k)
    {
        int count = 0;
        void GenerateArrays(int[] currentArray, int currentIndex, int m, int k)
        {
            if (currentIndex == currentArray.Length)
            {
                if (MentionedAlgorithmCost(currentArray) == k) count++;
                return; 
            }

            for (int i = 1; i <= m; i++)
            {                
                currentArray[currentIndex] = i;
                GenerateArrays(currentArray, currentIndex + 1, m, k);
            }
        }
        GenerateArrays(new int[n], 0, m, k);

        int MentionedAlgorithmCost(int[] arr)
        {
            int maximunValue = -1;
            int searchCost = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (maximunValue < arr[i])
                {
                    maximunValue = arr[i];
                    searchCost = searchCost + 1;
                    if (searchCost > k)
                        break;
                }
            }
            return searchCost;
        }
        return count;
    }
}

public class Solution_Best
{
    public int NumOfArrays(int n, int m, int k)
    {
        const int mod = 1000000007;

        int[][] dp = new int[m + 1][];
        int[][] prefix = new int[m + 1][];
        int[][] prevDp = new int[m + 1][];
        int[][] prevPrefix = new int[m + 1][];

        for (int i = 0; i <= m; i++)
        {
            dp[i] = new int[k + 1];
            prefix[i] = new int[k + 1];
            prevDp[i] = new int[k + 1];
            prevPrefix[i] = new int[k + 1];
        }

        for (int j = 1; j <= m; j++)
        {
            prevDp[j][1] = 1;
            prevPrefix[j][1] = j;
        }

        for (int i = 2; i <= n; i++)
        {
            for (int maxNum = 1; maxNum <= m; maxNum++)
            {
                for (int cost = 1; cost <= k; cost++)
                {
                    dp[maxNum][cost] = (int)(((long)maxNum * prevDp[maxNum][cost]) % mod);

                    if (maxNum > 1 && cost > 1)
                    {
                        dp[maxNum][cost] = (dp[maxNum][cost] + prevPrefix[maxNum - 1][cost - 1]) % mod;
                    }

                    prefix[maxNum][cost] = (prefix[maxNum - 1][cost] + dp[maxNum][cost]) % mod;
                }
            }

            for (int j = 1; j <= m; j++)
            {
                Array.Copy(dp[j], prevDp[j], k + 1);
                Array.Copy(prefix[j], prevPrefix[j], k + 1);
            }
        }

        return prefix[m][k];
    }
}