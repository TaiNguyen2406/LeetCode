using System;

namespace ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(char.IsLetter(',').ToString());
            string s;
            //s = "A man, a plan, a canal: Panama";
            //Console.WriteLine(IsPalindrome(s).ToString());
            //s = "race a car";
            //Console.WriteLine(IsPalindrome(s).ToString());
            s = "0P";
            Console.WriteLine(IsPalindrome(s).ToString());
        }

        public static bool IsPalindrome(string s)
        {
            s = s.Trim();
            var d = s.Length - 1;
        
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsLetter(s[i]) && !char.IsNumber(s[i]))
                    continue;
                if (!char.IsLetter(s[d]) && !char.IsNumber(s[d]))
                {
                    d--;
                    i--;
                    continue;
                }
                if (char.ToLower(s[i]) != char.ToLower(s[d]))
                {
                    return false;
                }
                d--;
            }
            return true;
        }

        public static bool IsLetterChar(char c)
        {
            if ('a' <= c && c <= 'z')
                return true;
            if ('A' <= c && c <= 'Z')
                return true;
            return false;
        }
    }
}
