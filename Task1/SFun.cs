using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    internal static class SFun
    {
        public static uint WordCount(string str, char ch)
        {
            string[] words = str.Split(new char[] {',','.'});
            uint count = 0;
            Regex regex1 = new Regex(@"[a-zA-Z]");
            foreach (string word in words)
            {
                if (word.StartsWith(ch)&regex1.IsMatch(word))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
