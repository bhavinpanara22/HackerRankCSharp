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

class TheHurdleRace
{
    // Complete the hurdleRace function below.
    static int HurdleRace(int k, int[] height)
    {
        int maxHurdleHeight = height.Max();
        return maxHurdleHeight <= k ? 0 : maxHurdleHeight - k;
    }

    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     string[] nk = Console.ReadLine().Split(' ');
    //
    //     int n = Convert.ToInt32(nk[0]);
    //     int k = Convert.ToInt32(nk[1]);
    //
    //     int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp));
    //     int   result = HurdleRace(k, height);
    //
    //     textWriter.WriteLine(result);
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}