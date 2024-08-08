using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using PracticeProblems._1._Easy;
using PracticeProblems._3._Hard;
using PracticeProblems._2._Medium;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 177.15;
            double num2 = 8234.33;
            double result = Multiply.Multiplies(num1, num2);

            Console.WriteLine($"The product of {num1} and {num2} is: {result}");
        }
    }
}