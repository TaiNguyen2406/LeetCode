using System;

namespace ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "anagram";
            var t = "nagaram";
            Console.WriteLine(IsAnagram(s,t).ToString());
            s = "rat";
            t = "car";
            Console.WriteLine(IsAnagram(s, t).ToString());
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] fs = new int[256];
            int[] ft = new int[256];
            for (int i = 0; i < 256; i++)
            {
                fs[i] = 0;
                ft[i] = 0;
            }
               
            for (int i = 0; i < s.Length; i++)
            {
                fs[s[i]] = fs[s[i]]+1;
                ft[t[i]] = ft[t[i]]+1;              
            }
            for (int i = 0; i < 256; i++)
            {
                if (fs[i] != ft[i])
                    return false;
            }
            return true;
        }
    }
}
