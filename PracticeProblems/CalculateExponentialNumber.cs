using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class CalculateExponentialNumber
    {
        public static int GetExpoNumber(int num, int pow) 
        {
            int trackNum = num; //keeps track of multiplied number
            int result = 0;

            for (int i = 1; i < pow; i++) // loops through until i = pow
            {
                result = num * trackNum; // sets result to num * trackedNum
                trackNum = result; // updates trackNum to product of num and trackedNum
            }

            return result;
        }
    }
}
