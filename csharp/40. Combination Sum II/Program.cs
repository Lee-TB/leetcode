var sln = new Solution();
int[] candidates = [10, 1, 2, 7, 6, 1, 5];
int target = 8;
var list = sln.CombinationSum2(candidates, target);
Console.WriteLine(list.Count);

public class Solution
{
    IList<IList<int>> answer;
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        answer = new List<IList<int>>();
        Array.Sort(candidates);
        GenerateCombinations(candidates, target, 0, new bool[candidates.Length], new List<int>());
        return answer;
    }

    private void GenerateCombinations(int[] candidates, int remaining, int index, bool[] used, IList<int> innerList)
    {
        if (remaining < 0) return;
        else if (remaining == 0) answer.Add(innerList.ToList());
        else
        {
            for (int i = index; i < candidates.Length; i++)
            {

                if (used[i] || (i > index && candidates[i] == candidates[i - 1] && !used[i]))
                    continue;

                innerList.Add(candidates[i]);
                used[i] = true;
                GenerateCombinations(candidates, remaining - candidates[i], i + 1, used, innerList);
                innerList.RemoveAt(innerList.Count - 1);
                used[i] = false;
            }
        }
    }
}

//public class Solution
//{
//    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
//    {
//        IList<IList<int>> answer = new List<IList<int>>();
//        Array.Sort(candidates);
//        backtrack(answer, new List<int>(), candidates, target, 0);
//        return answer;
//    }
//    private void backtrack(IList<IList<int>> list, IList<int> innerList,  int[] candidates, int totalLeft, int index)
//    {
//        if (totalLeft < 0)
//        {
//            return;
//        }

//        else if (totalLeft == 0)
//        {
//            list.Add(innerList);
//        }
//        else
//        {
//            for (int i = index; i < candidates.Length && totalLeft >= candidates[i]; i++)
//            {
//                if (i > index && candidates[i] == candidates[i - 1]) continue;
//                innerList.Add(candidates[i]);
//                backtrack(list, innerList, candidates, totalLeft - candidates[i], i + 1);
//                innerList.RemoveAt(innerList.Count - 1);// remove last element
//            }
//        }
//    }
//}