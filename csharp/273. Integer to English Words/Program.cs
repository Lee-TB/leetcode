﻿
using System.Text;

var sln = new Solution();
Console.WriteLine(sln.NumberToWords(12));
Console.WriteLine(sln.NumberToWords(10203));
Console.WriteLine(sln.NumberToWords(2));
public class Solution
{
    private static readonly string[] belowTwenty = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    private static readonly string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    private static readonly string[] thousands = { "", "Thousand", "Million", "Billion" };

    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return "Zero";
        }

        int i = 0;
        string words = "";

        while (num > 0)
        {
            if (num % 1000 != 0)
            {
                words = Helper(num % 1000) + thousands[i] + " " + words;
            }
            num /= 1000;
            i++;
        }

        return words.Trim();
    }

    private static string Helper(int num)
    {
        if (num == 0)
        {
            return "";
        }
        else if (num < 20)
        {
            return belowTwenty[num] + " ";
        }
        else if (num < 100)
        {
            return tens[num / 10] + " " + Helper(num % 10);
        }
        else
        {
            return belowTwenty[num / 100] + " Hundred " + Helper(num % 100);
        }
    }
}