namespace DetermineIfTwoStringsAreClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "caabbbzd";
            string s2 = "baacccdz";
            Console.WriteLine(CloseStrings(s1,s2));
        }

        public static bool CloseStrings(string word1, string word2)
        {
            HashSet<char> hs = new(word2); // O(1) - 26 chars max
            var freq1 = new int[26];
            var freq2 = new int[26];
            if(word1.Length != word2.Length)
            {
                return false;
            }
            for (int i = 0; i < word1.Length; i++)
            {
                freq1[word1[i] - 'a']++;
                if (hs.Add(word1[i])) return false;
                freq2[word2[i] - 'a']++;
            }
           
            for (int i = 0; i < word2.Length; i++)
            {
                
            }    
              
            Array.Sort(freq1); // O(1) - O(26*log26)
            Array.Sort(freq2);

            return freq1.SequenceEqual(freq2); // O(1) - 26 chars
        }
    }
}