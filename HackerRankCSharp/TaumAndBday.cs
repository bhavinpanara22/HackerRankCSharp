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

class ResultTaumAndBday
{
    /*
     * Complete the 'taumBday' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER b
     *  2. INTEGER w
     *  3. INTEGER bc
     *  4. INTEGER wc
     *  5. INTEGER z
     */

    public static long TaumBday(int b, int w, int bc, int wc, int z)
    {
        long priceB = Math.Min(bc, wc + z);
        long priceW = Math.Min(wc, bc + z);

        return (b * priceB) + (w * priceW);
    }
}

class TaumAndBday
{
    // public static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     int t = Convert.ToInt32(Console.ReadLine().Trim());
    //
    //     for (int tItr = 0; tItr < t; tItr++)
    //     {
    //         string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
    //         int      b                  = Convert.ToInt32(firstMultipleInput[0]);
    //         int      w                  = Convert.ToInt32(firstMultipleInput[1]);
    //
    //         string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
    //         int      bc                  = Convert.ToInt32(secondMultipleInput[0]);
    //         int      wc                  = Convert.ToInt32(secondMultipleInput[1]);
    //         int      z                   = Convert.ToInt32(secondMultipleInput[2]);
    //
    //         long result = ResultTaumAndBday.TaumBday(b, w, bc, wc, z);
    //
    //         textWriter.WriteLine(result);
    //     }
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}