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

class TwoDArrayDS
{
    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        if (arr.Length <= 2 && arr[0].Length <= 2) return 0;

        int result = int.MinValue;
        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = 0; j < arr[0].Length - 2; j++)
            {
                int mySum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                
                if (mySum > result) 
                    result = mySum;
            }
        }

        return result;
    }

    // static void Main(string[] args)
    // {
    //     EntryPoint(args);
    // }

    static void EntryPoint(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}