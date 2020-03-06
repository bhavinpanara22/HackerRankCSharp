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

class ViralAdvertising
{
    // Complete the viralAdvertising function below.
    static int ViralAds(int n)
    {
        int result = 0, currentNum = 5;

        for (int i = 0; i < n; i++)
        {
            currentNum /= 2;
            result     += currentNum;
            currentNum *= 3;
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = ViralAds(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}