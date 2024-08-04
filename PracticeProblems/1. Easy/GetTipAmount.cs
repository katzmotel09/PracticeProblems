using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class GetTipAmount
    {
        public static double TipAmount(double totalAmount, double tipPercent) 
        {
            double tip = 0;

            tip = totalAmount * tipPercent; // set tip to amount*percentage

            return Math.Round(tip, 2); // round tip, with 2 decimal points
        }
    }
}
