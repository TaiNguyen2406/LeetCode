using System;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1,0,1 };
            Console.WriteLine(SingleNumber(nums).ToString());
        }

        public static int SingleNumber(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            var len = nums.Length;
            for (var i = 0; i < len - 1; i++)
            {
                var dup = false;
                for (var j = i + 1; j < len; j++)
                {
                    Console.WriteLine(string.Join(",", nums));
                    if (nums[i] == nums[j])
                    {
                        dup = true;
                        if (j < len-1)
                        {
                            for (var k = j; k < len - 1; k++)
                            {
                                nums[k] = nums[k + 1];

                            }
                            len--;
                        }
                       
                    }
                    if (!dup && j == len - 1)
                    {
                        return nums[i];
                    }
                }
            }
            return nums[nums.Length - 1];
        }
    }
}
