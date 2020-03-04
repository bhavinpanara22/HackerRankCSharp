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

class SockMerchant
{
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        Array.Sort(ar);

        int result = 0;

        for (int i = 0; i < n -1 ; i++)
        {
            if (ar[i] == ar[i + 1])
            {
                result++;
                i++;
            }
        }

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}