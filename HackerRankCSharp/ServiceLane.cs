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

class ServiceLane
{
    static int[] ServiceLaneMethod(int n, int[][] cases, int[] width)
    {
        int[] result = new int[cases.Length];
        for (int i = 0; i < cases.Length; i++)
        {
            int temp = int.MaxValue;
            for (int j = cases[i][0]; j <= cases[i][1]; j++)
                temp = Math.Min(temp, width[j]);

            result[i] = temp;
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nt = Console.ReadLine().Split(' ');
        int      n  = Convert.ToInt32(nt[0]);
        int      t  = Convert.ToInt32(nt[1]);

        int[]   width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp));
        int[][] cases = new int[t][];

        for (int i = 0; i < t; i++)
        {
            cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
        }

        int[] result = ServiceLaneMethod(n, cases, width);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}