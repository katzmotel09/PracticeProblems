using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeProblems._2._Medium
{
    internal class VowelCount
    {
        public static int VCount(string sentence) 
        {
            int count = 0;

            foreach (char c in sentence) 
            {
                if (c ==  'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') 
                {
                    count++;
                }
            }

            return count;
        }
    }
}
//Create a function that takes one string as a parameter.
//The function should return the number of vowels in the string passed in.
//Print the value to the console.