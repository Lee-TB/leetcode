Console.WriteLine("1590. Make Sum Divisible by P");
int[] nums = [1000000000, 1000000000, 1000000000];
int p = 3;
long sum = nums.Sum(num => (long)num);
int remainder = (int)(sum % p);
Console.WriteLine(remainder);