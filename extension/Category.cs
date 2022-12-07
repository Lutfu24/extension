using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension
{
    internal class Category
    {
        public string Sentence;
        public string[] Words;
        public Category(string sentence, string[] words)
        {
            Sentence = sentence;
            Words = words;
        }
    }
}
