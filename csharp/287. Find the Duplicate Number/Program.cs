namespace _287._Find_the_Duplicate_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 3, 4, 2, 2 };
            Console.WriteLine(FindDuplicate(nums));
        }

        public static int FindDuplicate(int[] nums)
        {
            List<int> list = new List<int>();
            foreach (var num in nums)
            {
                if (list.Contains(num))
                {
                    return num;
                }
                list.Add(num);
            }
            return 0;
        }
    }
}