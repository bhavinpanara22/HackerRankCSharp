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

class LisasWorkbook
{
    // Complete the workbook function below.

    // Sample Input
    //
    // 5 3  
    // 4 2 6 1 10

    // Sample Output
    //
    // 4

    static int Workbook(int n, int k, int[] arr)
    {
        int page   = 1;
        int result = 0;

        foreach (var problem in arr)
        {
            for (int i = 1; i <= problem; i++)
            {
                if (i == page)
                    result++;

                if (i % k == 0)
                    page++;
            }

            if (problem % k != 0)
                page++;
        }

        return result;
    }

    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     string[] nk  = Console.ReadLine().Split(' ');
    //     int      n   = Convert.ToInt32(nk[0]);
    //     int      k   = Convert.ToInt32(nk[1]);
    //     int[]    arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    //
    //     int result = Workbook(n, k, arr);
    //
    //     textWriter.WriteLine(result);
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}