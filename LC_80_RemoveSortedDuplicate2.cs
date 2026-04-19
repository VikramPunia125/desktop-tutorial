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
                if (nums[i] != nums[i - 2])
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
            int result = Solution.RemoveDuplicates([1, 1, 1, 2, 2, 3]);
            Console.WriteLine(result);
        }
    }
}