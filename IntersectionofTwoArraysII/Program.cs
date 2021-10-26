using System;

namespace IntersectionofTwoArraysII
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1,2};
            var nums2 = new int[] { 1, 1 };
            Console.WriteLine(string.Join(",", Intersect(nums1, nums2)));
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            int compare = len1 - len2;
            if (compare < 0)
            {
                return Check(nums1, nums2);
            }
            else
            {
                return Check(nums2, nums1);
            }

        }

        private static int[] Check(int[] nums1, int[] nums2)
        {

            int d = 0;
            var len2 = nums2.Length;
            for (int i = 0; i < nums1.Length; i++)
            {
                
                for (int j = 0; j < len2; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        nums1[d] = nums1[i];
                        d++;
                        for (int a = j; a < len2 - 1; a++)
                        {
                            nums2[a] = nums2[a + 1];
                           
                        }
                        len2--;
                        Console.WriteLine(len2);
                        Console.WriteLine(string.Join(",", nums2));
                        //if (j == len2-1)
                        //{
                        //    len2--;
                        //}
                            
                       
                        break;
                    }
                }
            }
            int[] result = new int[d];
            for (int i = 0; i < d; i++)
            {
                result[i] = nums1[i];
            }

            return result;
        }
    }
}
