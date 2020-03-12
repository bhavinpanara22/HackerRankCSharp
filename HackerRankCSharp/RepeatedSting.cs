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

class RepeatedString
{
    // Complete the repeatedString function below.
    static long RepeatedStringMethod(string s, long n)
    {
        var inSingle = s.Count(x => x == 'a');
        var full = n / s.Length;
        var rest = n % s.Length;
        var inRest = s.Substring(0, (int)rest).Count(x => x == 'a');

        var result = (inSingle * full) + inRest;
        
        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s      = Console.ReadLine();
        long   n      = Convert.ToInt64(Console.ReadLine());
        long   result = RepeatedStringMethod(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}