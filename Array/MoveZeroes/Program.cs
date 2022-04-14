using System;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0,0, 1};
            MoveZeroes(nums);
            Console.WriteLine(string.Join(",", nums));
        }

        public static void MoveZeroes(int[] nums)
        {
            var d = nums.Length - 1;
            var lens = d;
            for (int i = 0; i < lens; i++)
            {
                if(nums[i]==0)
                {
                    for (int j = i; j < lens; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[d] = 0;
                    d--;
                    lens--;
                    i--;
                }
                Console.WriteLine(string.Join(",", nums));
            }
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
