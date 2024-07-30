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
            int trackNum = num;
            int result = 0;

            for (int i = 1; i < pow; i++) 
            {
                result = num * trackNum;
                trackNum = result;
            }

            return result;
        }
    }
}
