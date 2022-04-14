using System;

namespace FirstUniqueCharacterInaString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] fi = new char[256];
           
            string s = "";
            //s = "leetcode";
            //Console.WriteLine(FirstUniqChar(s));
            s = "loveleetcode";
            Console.WriteLine(FirstUniqChar(s));  
            //s = "aabb";
            //Console.WriteLine(FirstUniqChar(s));
        }

        public static int FirstUniqChar(string s)
        {
            int[] fi = new int[256]; // array to store First Index

            // initializing all elements to -1
            for (int i = 0; i < 256; i++)
                fi[i] = -1;

            // sets all repeating characters to -2 and
            // non-repeating characters contain the index where
            // they occur
            for (int i = 0; i < s.Length; i++)
            {
                //use char as array key
                if (fi[s[i]] == -1)
                {
                    fi[s[i]] = i;
                }
                else
                {
                    fi[s[i]] = -2;
                }
            }

            int res = int.MaxValue;

            for (int i = 0; i < 256; i++)
            {

                // If this character is not -1 or -2 then it
                // means that this character occurred only once
                // so find the min index of all characters that
                // occur only once, that's our first index
                if (fi[i] >= 0)
                    res = Math.Min(res, fi[i]);
            }

            // if res remains  Integer.MAX_VALUE, it means there
            // are no characters that repeat only once or the
            // string is empy
            if (res == int.MaxValue)
                return -1;
            else
                return res;
        }
    }
}
