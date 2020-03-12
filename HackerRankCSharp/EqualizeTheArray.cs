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

class EqualizeTheArray
{
    // Complete the equalizeArray function below.
    static int EqualizeArray(int[] arr)
    {
        var distinct = arr.Distinct();

        int result = 0;
        foreach (var temp in distinct)
            result = Math.Max(result, arr.Count(x => x == temp));

        return arr.Length - result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int   n      = Convert.ToInt32(Console.ReadLine());
        int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int   result = EqualizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}