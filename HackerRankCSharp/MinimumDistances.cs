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

class MinimumDistances
{
    // Complete the minimumDistances function below.
    static int MinimumDistancesMethod(int[] a)
    {
        int  minDistance = int.MaxValue;
        bool isFound     = false;

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] == a[j] && j - i < minDistance)
                {
                    minDistance = j - i;
                    isFound     = true;
                }
            }
        }

        if (isFound)
            return minDistance;

        return -1;
    }

    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     int   n = Convert.ToInt32(Console.ReadLine());
    //     int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
    //
    //     int result = MinimumDistancesMethod(a);
    //
    //     textWriter.WriteLine(result);
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}