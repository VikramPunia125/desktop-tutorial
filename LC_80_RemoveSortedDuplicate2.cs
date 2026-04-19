namespace Solution
{
    public class Solution
    {
        static int d = 2;
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= d)
                return nums.Length;

            int k = d;
            for (int i = d; i < nums.Length; i++)
            {
                if (nums[i] != nums[k - d])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 1, 2, 2, 3 };
            Console.WriteLine(string.Join(", ", nums));
            Console.WriteLine(nums.Length);
            int result = Solution.RemoveDuplicates(nums);
            Console.WriteLine(string.Join(", ", nums.Take(result)));
            Console.WriteLine(result);
        }
    }
}