using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal static class SFun
    {
        public static List<string> WordSEndings(string str)
        {
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char ch = words[0].Last();
            List<string> strings = new List<string>();
            foreach (string word in words)
            {
                if(word.EndsWith(ch)) strings.Add(word);   
            }
            return strings;
        }
    }
}
