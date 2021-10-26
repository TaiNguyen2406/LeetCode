using System;

namespace SortArrayByParityII
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 3,1,4,2 };
            var result = SortArrayByParityII(nums);
            Console.WriteLine(string.Join(",", result));
        }

        public static int[] SortArrayByParityII(int[] nums)
        {
            int odd = 1, even = 0;
            int temp;
            while (odd <= nums.Length - 1 && even < nums.Length)
            {
                Console.WriteLine(nums[odd]);
                Console.WriteLine(nums[even]);
                if (nums[odd] % 2 == 0 && nums[even] % 2 != 0)
                {
                    temp = nums[odd];
                    nums[odd] = nums[even];
                    nums[even] = temp;
                }
                if (nums[odd] % 2 != 0)
                    odd += 2;
                if (nums[even] % 2 == 0)
                    even += 2;
                Console.WriteLine(string.Join(",", nums));
            }
            return nums;
        }
    }
}
