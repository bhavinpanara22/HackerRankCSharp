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

class ResultPN
{
    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        int maxLength = 0;
        a.Sort();

        for (int i = 0; i < a.Count; i++)
        {
            int endPoint   = (a.Contains(a[i] + 1)) ? a.LastIndexOf(a[i] + 1) : a.LastIndexOf(a[i]);
            int tempLength = endPoint - i + 1;
            if (tempLength > maxLength)
                maxLength = tempLength;

            i = a.LastIndexOf(a[i]);
        }

        return maxLength;
    }
}

class PickingNumbers
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = ResultPN.pickingNumbers(a);

        Console.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}