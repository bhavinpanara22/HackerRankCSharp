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

class MigratoryBirds
{
    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
    //
    //     List<int> arr   = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    //     List<int> count = new List<int>() {0, 0, 0, 0, 0};
    //     foreach (var temp in arr)
    //         count[temp - 1]++;
    //
    //     int maxOccur = count.Max();
    //     int result   = count.IndexOf(maxOccur) + 1;
    //
    //     textWriter.WriteLine(result);
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}