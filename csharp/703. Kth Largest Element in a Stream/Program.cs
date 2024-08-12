var kthLargest = new KthLargest(3, new[] { 4, 5, 8, 2 });
Console.WriteLine(kthLargest.Add(3)); // {2, 3, 4, 5, 8} return 4;
Console.WriteLine(kthLargest.Add(5));   // {2, 3, 4, 5, 5, 8} return 5
Console.WriteLine(kthLargest.Add(10));  // {2, 3, 4, 5, 5, 8, 10} return 5
Console.WriteLine(kthLargest.Add(9));   // {2, 3, 4, 5, 5, 8, 9, 10} return 8
Console.WriteLine(kthLargest.Add(4));   // {2, 3, 4, 4, 5, 5, 8, 9, 10} return 8
public class KthLargest
{
  private List<int> _stream;
  private int _k;
  public KthLargest(int k, int[] nums)
  {
    _k = k;
    _stream = new List<int>();

    Array.Sort(nums);
    foreach (int num in nums)
    {
      _stream.Add(num);
    }
  }

  public int Add(int val)
  {
    int indexOfVal = FindIndex(val);
    _stream.Insert(indexOfVal, val);
    return _stream[_stream.Count - _k];
  }

  private int FindIndex(int val)
  {
    int left = 0;
    int right = _stream.Count - 1;
    while (left <= right)
    {
      int mid = (left + right) / 2;
      if (_stream[mid] == val) return mid;
      if (_stream[mid] < val)
        left = mid + 1;
      else
        right = mid - 1;
    }
    return left;
  }
}