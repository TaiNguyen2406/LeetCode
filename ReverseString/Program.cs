using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new char[] { 'h', 'e', 'l', 'l','o'};
            ReverseString(s);
            Console.WriteLine(string.Join(',', s));
            s = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            ReverseString(s);
            Console.WriteLine(string.Join(',', s));
        }

        public static void ReverseString(char[] s)
        {
            int d = s.Length - 1;
            for (int i = 0; i < s.Length/2; i++)
            {
                var temp = s[i];
                s[i] = s[d];
                s[d] = temp;
                d--;
            }
        }
    }
}
