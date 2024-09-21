int n = 23;
var sln = new Solution();
var lexiNums = sln.LexicalOrder(n);
for (int i = 0; i < lexiNums.Count; i++)
{
    Console.WriteLine(lexiNums[i]);
}

public class Solution
{
    public IList<int> LexicalOrder(int n)
    {
        List<int> list = new List<int>();
        for (int i = 1; i <= 9; i++)
        {
            GenerateLexicalNumbers(i, n, list);
        }
        return list;
    }

    private void GenerateLexicalNumbers(int number, int n, List<int> list)
    {
        if (number > n) return;
        list.Add(number);

        // insert digits to the number
        for (int i = 0; i <= 9; i++)
        {
            int nextNumber = number * 10 + i;
            if (nextNumber <= n)
            {
                GenerateLexicalNumbers(nextNumber, n, list);
            }
            else
            {
                break;
            }
        }
    }

    public IList<int> LexicalOrder2(int n)
    {
        List<int> list = Enumerable.Range(1, n).ToList();
        list.Sort((a, b) =>
        {
            string aStr = a.ToString();
            string bStr = b.ToString();
            return aStr.CompareTo(bStr);
        });
        return list;
    }
}