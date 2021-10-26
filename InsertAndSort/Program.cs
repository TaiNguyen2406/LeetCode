using System;

namespace InsertAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0,1,2,3,5,6 };
            Console.WriteLine(string.Join(',', InsertAndSort(nums, 4)));
        }

        public static int[] InsertAndSort(int[] a, int p)
        {
            int arrIndex = a.Length - 1;
            int tempIndex = a.Length;
            int[] tempArr = new int[tempIndex + 1];
            bool inserted = false;
            for (int i = tempIndex ; i >=0; i--)
            {
                if(arrIndex > -1 && a[arrIndex] >p)
                {
                    tempArr[i] = a[arrIndex--];
                }
                else
                {
                    if(!inserted)
                    {
                        tempArr[i] = p;
                        inserted = true;
                    }
                    else
                    {
                        tempArr[i] = a[arrIndex--];
                    }
                }
            }
            return tempArr;
        }
    }
}
