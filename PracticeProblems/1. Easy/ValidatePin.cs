using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class ValidatePin
    {
        public static void ValidPin(int num1, int num2) 
        {
            string validate = "valid";

            if (num1 == num2) 
            {
                Console.Write(validate);
            }
            else 
            {
                validate = "inavlid";

                Console.Write(validate);
            }
        }
    }
}
//Create a function that takes 2 for digit integers as a parameters.
//The function should check if both the numbers are the same.
//Print Valid or invalid basis off the result.