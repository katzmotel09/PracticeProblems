using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 9;
            int power = 3;
            int result = CalculateExponentialNumber.GetExpoNumber(number, power);

            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Power: {power}");
            Console.WriteLine($"Exponential number: {result}");
        }
    }
}
