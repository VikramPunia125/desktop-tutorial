namespace Solution
{
    public class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Length;

            int k = 2;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[k - 2])
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
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            int result = Solution.RemoveDuplicates(nums);
            Console.WriteLine(string.Join(", ", nums));
            Console.WriteLine(result);
        }
    }
}