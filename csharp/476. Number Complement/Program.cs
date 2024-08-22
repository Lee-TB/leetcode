var sln = new Solution();

Console.WriteLine(sln.FindComplement(5)); // 2
public class Solution
{
    public int FindComplement(int num)
    {
        // get the length of the binary representation of the number
        int bitLen = Convert.ToString(num, toBase: 2).Length;

        int mask = (1 << bitLen) - 1; // if bitLen = 3, mask = 1000 - 1 = 111

        return mask ^ num;
    }
}