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

class SequenceEquation
{
    static int[] PermutationEquation(int[] p)
    {
        List<int> pList  = p.ToList();
        List<int> result = new List<int>();

        for (int i = 1; i <= p.Length; i++)
            result.Add(pList.IndexOf(pList.IndexOf(i) + 1) + 1);

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int   n      = Convert.ToInt32(Console.ReadLine());
        int[] p      = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));
        int[] result = PermutationEquation(p);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}