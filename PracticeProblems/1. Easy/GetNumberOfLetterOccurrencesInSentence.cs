using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class GetNumberOfLetterOccurrencesInSentence
    {
        public static int LetterOccurence(string sentence, char letter) 
        {
            int result = sentence.ToCharArray().Count(c => c == letter);

            return result;
        }
    }
}
//Create a function that takes a sentence and a letter as parameters.
//Return the number of iterations of that given letter.
//Print the number of letters to the console.