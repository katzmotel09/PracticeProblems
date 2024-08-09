using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeProblems._3._Hard
{
    internal class AverageWordLength
    {
        public static double AverageLength(string sentence) 
        {
            Regex pattern = new("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            string cleanSentence = pattern.Replace(sentence, "");
            string[] words = cleanSentence.Split(' ');

            double numberOfWords = words.Length;
            double totalLetters = 0;
            foreach (string word in words) 
            {
                totalLetters += word.Length;
            }

            double avg = Convert.ToDouble(totalLetters) / Convert.ToDouble(numberOfWords);

            return Math.Round(avg, 2);
            
        }
    }
}
//Create a function that takes a string as a parameter.
//The function should return the average of length of the words in the string.
//Remove all special characters before computing the average.
//Return the average word count.
//Print the value to the console.