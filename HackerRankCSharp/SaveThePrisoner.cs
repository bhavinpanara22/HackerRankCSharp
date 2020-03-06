using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class SaveThePrisoner
{
    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     int t = Convert.ToInt32(Console.ReadLine());
    //
    //     for (int tItr = 0; tItr < t; tItr++)
    //     {
    //         string[] nms = Console.ReadLine().Split(' ');
    //
    //         int n      = Convert.ToInt32(nms[0]);
    //         int m      = Convert.ToInt32(nms[1]);
    //         int s      = Convert.ToInt32(nms[2]);
    //         int result = (s - 1 + m) % n;
    //         if (result == 0)
    //             result = n;
    //
    //         textWriter.WriteLine(result);
    //     }
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}