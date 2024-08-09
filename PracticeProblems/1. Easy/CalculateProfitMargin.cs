using PracticeProblems._1._Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class CalculateProfitMargin
    {
        public static double Profits(double revenue, double cost) 
        {
            double profit = (revenue - cost) / revenue;

            return profit;
        }
    }
}
//Create a function that takes two doubles as a parameter. (revenue, cost)
//The function should calculate the profit margin based off the formula below.
//Print the value to the console.
//Divide your net income by your revenue (also called net sales) 
//Multiply your total by 100 to get your profit margin percentage.