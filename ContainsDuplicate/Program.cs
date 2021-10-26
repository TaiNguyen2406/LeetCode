using System;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(ContainsDuplicate(nums).ToString());
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
