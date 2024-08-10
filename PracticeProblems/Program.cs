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
            int width = 4;
            int length = 2;
            int height = 2;
            int result = ComputeVolume.Volume(width, length, height);

            Console.WriteLine(result);
            
        }
    }
}