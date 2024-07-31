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
            int[] colorArray = new int[] { 255, 255, 255 };

            int[] invertedColorArray = InvertColorArray.InvertColor(colorArray);

            foreach (int value in invertedColorArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}
