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
            double b = 10.9;
            double h = 15.5;
            double area = AreaOfTriangle.Triangle(b, h);

            Console.WriteLine("The area of a triangle");
            Console.WriteLine($"Base: {b}");
            Console.WriteLine($"Height: {h}");
            Console.WriteLine($"Area: {area}");
        }
    }
}