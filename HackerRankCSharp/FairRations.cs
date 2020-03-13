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

class FairRations
{
    // Complete the fairRations function below.
    static int FairRationsMethod(int[] B)
    {
        if (B.Sum() % 2 == 1) 
            return -1;

        int count = 0;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] % 2 == 1)
            {
                B[i]++;
                B[i + 1]++;
                count += 2;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int   N = Convert.ToInt32(Console.ReadLine());
        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));

        int result = FairRationsMethod(B);

        if (result == -1)
            textWriter.WriteLine("NO");
        else
            textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}