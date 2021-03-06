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

class SherlockAndSquares
{
    // Complete the Squares function below.
    static int Squares(int a, int b)
    {
        // adding one at the end because we want to include all numbers from start to end.
        return (int) Math.Floor(Math.Sqrt(b)) - (int) Math.Ceiling(Math.Sqrt(a)) + 1;
    }

    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     int q = Convert.ToInt32(Console.ReadLine());
    //
    //     for (int qItr = 0; qItr < q; qItr++)
    //     {
    //         string[] ab = Console.ReadLine().Split(' ');
    //
    //         int a      = Convert.ToInt32(ab[0]);
    //         int b      = Convert.ToInt32(ab[1]);
    //         int result = Squares(a, b);
    //
    //         textWriter.WriteLine(result);
    //     }
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}