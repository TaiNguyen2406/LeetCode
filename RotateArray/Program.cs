using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //Rotate(nums, 7);
            nums = new int[] { 1, 2, 3, 4, 5, 6 };
            //Rotate(nums, 1);
            nums = new int[] { 1, 2, 3, 4, 5, 6 };
            Rotate(nums, 2);
        }

        public static void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            if(k > 0)
            {
                reverse(nums, 0, nums.Length - 1);
                Console.WriteLine(string.Join(",", nums));
                reverse(nums, 0, k - 1);
                Console.WriteLine(string.Join(",", nums));
                reverse(nums, k, nums.Length - 1);
                Console.WriteLine(string.Join(",", nums));
            }
        }

        public static  void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
