using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems.Easy
{
    enum Format 
    {
        Parentheses,
        Dashed
    }
    internal class FormatPhoneNumber
    {
        public static string PhoneNumber(Format format, string number)
        { 
            string areaCode = number.Substring(1, 3);
            string midDigits = number.Substring(4, 3);
            string finalFour = number.Substring(7);

            string formatNum = "";
            string invalid = "Please enter a valid number beginning with 1!";

            if (number.StartsWith("1") && number.Length != 11) // verifies phone number is valid length
            {
                return invalid;
            }

            if (format == Format.Parentheses) 
            {
                formatNum += "1-";
                formatNum += areaCode + "-";
                formatNum += midDigits + "-";
                formatNum += finalFour;
            }

            if (format == Format.Dashed) 
            {
                formatNum += "+1";
                formatNum += "(" + areaCode + ")";
                formatNum += midDigits + "-";
                formatNum += finalFour;
            }

            return formatNum;
        }
    }
}
//Write a function to format a phone number from a string of 11 digits.
//The function should take 2 parameters, an enum with the options(Dashes or Parentheses) and a string.
//Format the string based off an enum value.
//The return format should be #-###-###-#### or +#(###)###-####.
//Return the string if the number doesn't start with 1 or is not 11 characters long.
//Print the output to the console window.