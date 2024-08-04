using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class ReverseWord
    {
        public static string ReverseString(string word) 
        {
            char[] chars = word.ToCharArray();

            Array.Reverse(chars);

            return new string(chars);
        }
    }
}
//Create a function that takes a word as a parameter.
//Return the reverse of that that word.
//Print the value to the console.