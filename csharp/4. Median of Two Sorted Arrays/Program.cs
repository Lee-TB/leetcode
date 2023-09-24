namespace _4._Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            int[] nums3 = nums1.Concat(nums2).ToArray();
            Array.Sort(nums3);

            Console.WriteLine(FindMedianSortedArrays_UsingMethod(nums1, nums2));
        
        }

        public static double FindMedianSortedArrays_UsingMethod(int[] nums1, int[] nums2)
        {
            var nums3 = nums1.Concat(nums2).ToArray();
            Array.Sort(nums3);

            if (nums3.Length % 2 == 0)
            {
                return (double)(nums3[nums3.Length / 2 - 1] + nums3[nums3.Length / 2]) / 2;
            }
            else
            {
                return (double)nums3[nums3.Length / 2];
            }
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length = nums1.Length + nums2.Length;
            int[] mergedArray = new int[length];
            int i = 0;
            int j = 0;
            while ((i + j) < length)
            {
                if (i < nums1.Length && j < nums2.Length)
                {
                    if (nums1[i] < nums2[j])
                    {
                        mergedArray[i + j] = nums1[i];
                        i++;
                    }
                    else
                    {
                        mergedArray[i + j] = nums2[j];
                        j++;
                    }
                }
                else
                {
                    if (i < nums1.Length)
                    {
                        mergedArray[i + j] = nums1[i];
                        i++;
                    }
                    else
                    {
                        mergedArray[i + j] = nums2[j];
                        j++;
                    }
                }

            }

            if (length % 2 == 0)
            {
                return (double)(mergedArray[length / 2] + mergedArray[length / 2 - 1]) / 2;
            }
            else
            {
                return (double)mergedArray[length / 2];
            }
        }
    }
}

