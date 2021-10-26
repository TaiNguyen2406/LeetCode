using System;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            var k = RemoveDuplicates(nums);
            int[] expectedNums = { 0,1, 2, 3, 4};
           
            for (int i = 0; i < k; i++)
            {
                if (nums[i] != expectedNums[i])
                    Console.WriteLine(nums[i]);
            }
            Console.WriteLine(k);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j++] = nums[i];
                }
            }
            nums[j++] = nums[nums.Length - 1];
            return j;
        }

        public static void RemoveAt<T>(T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                arr[a] = arr[a + 1];
            }
            
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);
        }
    }
}
