using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var dgits = new int[] { 9,9 };
            Console.WriteLine(string.Join(",", PlusOne(dgits)));
        }

        public static int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0)
            {
                int[] temp = { 1 };
                return temp;
            }

            int carry = 1;
            int i;
            for (i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    carry += digits[i];
                    digits[i] = carry;
                    break;
                }
            }
            if (i < 0)
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                return result;
            }
            else
            {
                return digits;
            }

            //double num = 0;
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    var exponent = digits.Length - 1 - i;
            //    num += digits[i] * Math.Pow(10, exponent);
            //}
            //num = num + 1;
            //int[] result = new int[(int)Math.Floor(Math.Log10(num) + 1)];
            //for (int i = result.Length - 1; i >= 0; i--)
            //{
            //    result[i] = (int)(num % 10);
            //    num /= 10;
            //}

            //return result;
        }
    }
}
