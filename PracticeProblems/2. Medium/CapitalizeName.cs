using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._2._Medium
{
    internal class CapitalizeName
    {
        public static string[] CapitalNames(string[] names) 
        {
            string[] capitalNames = new string[names.Length];
            
            for (int i = 0; i < names.Length; i++) 
            {
                char[] nameFormat = names[i].ToCharArray();

                for (int j = 0; j < nameFormat.Length; j++) 
                {
                    if (j == 0) 
                    {
                        string firstLetter = nameFormat[j].ToString().ToUpper();
                        nameFormat[j] = Convert.ToChar(firstLetter);
                    }
                    else 
                    {
                        string rest = nameFormat[j].ToString().ToLower();
                        nameFormat[j] = Convert.ToChar(rest);
                    }

                    capitalNames[i] = string.Join("", nameFormat);
                }
            }

            return capitalNames;
        }
    }
}
//Create a function that takes a string array as a parameter.
//The function should uppercase the first character of each string and lowercase the rest of the string.
//Return a list of capitalized names.
//Print the results to the console.