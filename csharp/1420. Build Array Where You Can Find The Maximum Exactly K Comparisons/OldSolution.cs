namespace _1420._Build_Array_Where_You_Can_Find_The_Maximum_Exactly_K_Comparisons;

internal class OldSolution
{
    //static void Main(string[] args)
    //{

    //    Console.WriteLine(NumOfArrays(50, 100, 1));
    //}

    public static int NumOfArrays(int n, int m, int k)
    {
        int count = 0;
        List<int[]> listOfArrays = GenerateArrays(n, m);
        listOfArrays.ForEach(arr =>
        {
            if (MentionedAlgorithmCost(arr) == k) count++;
        });
        return count;
    }

    static int MentionedAlgorithmCost(int[] arr)
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
            }
        }
        return searchCost;
    }

    static List<int[]> GenerateArrays(int n, int m)
    {
        List<int[]> result = new List<int[]>();
        GenerateArraysHelper(result, new int[n], 0, m);
        return result;
    }

    static void GenerateArraysHelper(List<int[]> result, int[] currentArray, int currentIndex, int m)
    {
        if (currentIndex == currentArray.Length)
        {
            int[] newArray = new int[currentArray.Length];
            Array.Copy(currentArray, newArray, currentArray.Length);
            result.Add(newArray);
            return;
        }

        for (int i = 1; i <= m; i++)
        {
            currentArray[currentIndex] = i;
            GenerateArraysHelper(result, currentArray, currentIndex + 1, m);
        }
    }
}
