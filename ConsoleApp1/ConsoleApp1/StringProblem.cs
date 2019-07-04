using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringProblem
    {
        public String reverse(String S)
        {
            StringBuffer sb = new StringBuffer(S);
            String letterS = "";
            for (int i = S.length() - 1; i >= 0; i--)
            {
                char ch = S.charAt(i);
                if (Character.isLetter(S.charAt(i)))
                {
                    letterS += ch;
                }
            }
            int p = 0;
            for (int i = 0; i < S.length(); i++)
            {
                if (Character.isLetter(S.charAt(i)))
                {
                    sb.setCharAt(i, letterS.charAt(p++));
                }
            }
            return sb.toString();
        }

    }
}
