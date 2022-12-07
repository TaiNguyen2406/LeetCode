using System;

namespace NumberOfSubmatricesThatSumToTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[3][];
            nums[0] = new int[] { 0, 1, 0 };
            nums[1] = new int[] { 1, 1, 1 };
            nums[2] = new int[] { 0, 1, 3 };
            var result = NumSubmatrixSumTarget(nums, 0);
            Console.WriteLine(result);
        }
        public static int NumSubmatrixSumTarget(int[][] matrix, int target)
        {
            int m = matrix.Length, n = matrix[0].Length;
            var sum = new int[m + 1][];
            for (int i = 0; i < m+1; i++)
            {
                sum[i] = new int[n + 1];
            }
            int count = 0;

            for (int x = 1; x <= m; x++)
            {
                for (int y = 1; y <= n; y++)
                {
                    sum[x][y] = matrix[x - 1][y - 1] + sum[x - 1][y] + sum[x][y - 1] - sum[x - 1][y - 1];
                    //Console.WriteLine($"{matrix[x - 1][y - 1]} + {sum[x - 1][y]} + {sum[x][y - 1]} - {sum[x - 1][y - 1]}");
                    Console.WriteLine($"sum[{x}][{y}] = {sum[x][y]}");
                    for (int i = 1; i <= x; i++)
                    {
                        for (int j = 1; j <= y; j++)
                        {
                            if (sum[x][j - 1] + sum[i - 1][y] - sum[i - 1][j - 1] + target == sum[x][y])
                                count++;
                        }
                    }

                }
            }

            return count;
        }
    }
}
