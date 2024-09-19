var sln = new Solution();
string expression = "21";
var res = (sln.DiffWaysToCompute(expression));
foreach (var item in res)
{
    Console.WriteLine(item);
}

public class Solution
{
    public IList<int> DiffWaysToCompute(string expression)
    {
        List<int> result = new List<int>();
        if (expression.Length == 0) return result;

        if (!(expression.Contains('+') || expression.Contains('-') || expression.Contains('*')))
        {
            result.Add(Int32.Parse(expression));
            return result;
        }

        for (int i = 0; i < expression.Length; i++)
        {
            char curChar = expression[i];
            if (char.IsDigit(curChar)) continue;

            IList<int> leftResult = DiffWaysToCompute(expression.Substring(0, i));
            IList<int> rightResult = DiffWaysToCompute(expression.Substring(i + 1));

            foreach (int leftValue in leftResult)
            {
                foreach (int rightValue in rightResult)
                {
                    int computedResult = curChar switch
                    {
                        '+' => leftValue + rightValue,
                        '-' => leftValue - rightValue,
                        '*' => leftValue * rightValue,
                    };
                    result.Add(computedResult);
                }
            }
        }

        return result;
    }
}