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

class AppendAndDelete
{
    static string AppendAndDeleteMethod(string s, string t, int k)
    {
        if (k >= s.Length + t.Length)
            return "Yes";

        int sameStringUptoIndex = 0;
        for (; sameStringUptoIndex < s.Length && sameStringUptoIndex < t.Length; sameStringUptoIndex++)
        {
            if (s[sameStringUptoIndex] != t[sameStringUptoIndex])
                break;
        }

        int minOperations = (s.Length - sameStringUptoIndex) + (t.Length - sameStringUptoIndex);
        if (k >= minOperations && (k - minOperations) % 2 == 0)
            return "Yes";

        return "No";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int    k = Convert.ToInt32(Console.ReadLine());

        string result = AppendAndDeleteMethod(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}