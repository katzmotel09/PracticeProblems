using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._2._Medium
{
    internal class GetCase
    {
        public static string Case(string word)
        {
            string caseResult = "";

            if (word != null)
            {
                caseResult = "Please type a word!";
            }
            else
            {
                if (word == word.ToLower())
                {
                    caseResult = "lower";
                }
                else if (word == word.ToUpper())
                {
                    caseResult = "upper";
                }
                else
                {
                    caseResult = "mixed";
                }
            }

            return caseResult;
        }
    }
}
//Create a function that takes one string as a parameter.
//The function should determine if the string passed in is all upper, lower, or mixed.
//Print the value to the console.