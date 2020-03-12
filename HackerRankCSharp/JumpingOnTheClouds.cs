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

class JumpingOnTheClouds
{
    // Complete the jumpingOnClouds function below.
    static int JumpingOnClouds(int[] c)
    {
        int result = 0;

        for (int i = 0; i < c.Length;)
        {
            if (i + 2 < c.Length && c[i + 2] == 0)
            {
                result++;
                i += 2;
                continue;
            }

            if (i + 1 < c.Length && c[i + 1] == 0)
                result++;

            i++;
        }

        return result;
    }

    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     int   n      = Convert.ToInt32(Console.ReadLine());
    //     int[] c      = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
    //     int   result = JumpingOnClouds(c);
    //
    //     textWriter.WriteLine(result);
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}