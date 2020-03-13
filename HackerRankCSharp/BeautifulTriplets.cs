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

class BeautifulTriplets
{
    // Complete the beautifulTriplets function below.
    static int BeautifulTripletsMethod(int d, int[] arr)
    {
        return arr.Count(temp => arr.Contains(temp + d) && arr.Contains(temp + (2 * d)));
    }

    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     string[] nd = Console.ReadLine().Split(' ');
    //
    //     int   n   = Convert.ToInt32(nd[0]);
    //     int   d   = Convert.ToInt32(nd[1]);
    //     int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    //
    //     int result = BeautifulTripletsMethod(d, arr);
    //
    //     textWriter.WriteLine(result);
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}