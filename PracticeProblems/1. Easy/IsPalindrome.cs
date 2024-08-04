using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class IsPalindrome
    {
        public static bool Palindrome(string word) 
        {
            bool isPalindrome = false;
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);

            if (word == new string(chars)) 
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
//Create a function that takes a word as a parameter.
//Checks whether it is a palindrome.
//Return true if the word is a palindrome or false if it is not.