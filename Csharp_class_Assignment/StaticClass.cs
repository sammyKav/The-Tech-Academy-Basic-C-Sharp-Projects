using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_class_Assignment
{

    static class  StaticClass
    {

        public static int strLen(string word)
        {
            int stringLength = word.Length;
            return stringLength;
        }

        public static int strLen(string word, string word2)
        {
          
                int word_diff = strLen(word) - word2.Length;
                return word_diff;
           
        }
    }

 }