using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace extension
{
    internal static class Extension
    {
       
        public static void customContains(this string sentence, string words)
        {
            words.ToLower();
            sentence.ToLower();
            int index = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == words[index])
                {
                    if (sentence[i+1] == words[index+1])
                    {
                        if (sentence[i+2] == words[index+2])
                        {
                            Console.WriteLine(true);
                        }
                    }
                }
            }
        }
    }
}
