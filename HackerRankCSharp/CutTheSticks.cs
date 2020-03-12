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

class CutTheSticks
{
    static int[] CutTheSticksMethod(int[] arr)
    {
        Array.Sort(arr);

        List<int> result = new List<int> {arr.Length};
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1])
                result.Add(arr.Length - i);
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int   n      = Convert.ToInt32(Console.ReadLine());
        int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] result = CutTheSticksMethod(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}