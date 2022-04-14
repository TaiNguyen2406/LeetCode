using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 7, 11, 15 };
            Console.WriteLine(string.Join(',',TwoSum(nums, 9)));
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i]+nums[j]==target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
