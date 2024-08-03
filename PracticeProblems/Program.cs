using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using PracticeProblems.Easy;
using PracticeProblems.Medium;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "15805714423";
            string formatNum = FormatPhoneNumber.PhoneNumber(Format.Dashed, number);

            Console.WriteLine(formatNum);
            
        }
    }
}
