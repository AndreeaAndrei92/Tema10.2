using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    class GoatLatin
    {
        private static string GoatLatinn(string S)
        {
            HashSet<char> str = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string[] words = S.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (str.Contains(words[i][0]))
                {
                    words[i] = String.Concat(words[i], "ma");
                }



                for (int x = 0; x < i + 1; x++)
                {
                    words[i] = String.Concat(words[i], "a");
                }
            }
            string output = String.Join(" ", words);
            return output;
        }
    }
}
