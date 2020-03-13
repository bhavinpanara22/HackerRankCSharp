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

class ChocolateFeast
{
    // Complete the chocolateFeast function below.
    static int ChocolateFeastMethod(int n, int c, int m)
    {
        int chocolates      = n / c;
        int currentWrappers = chocolates;

        while (currentWrappers / m >= 1)
        {
            chocolates += currentWrappers / m;
            int extraWrappers = currentWrappers % m;
            
            currentWrappers /= m;
            currentWrappers += extraWrappers;
        }

        return chocolates;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] ncm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(ncm[0]);
            int c = Convert.ToInt32(ncm[1]);
            int m = Convert.ToInt32(ncm[2]);

            int result = ChocolateFeastMethod(n, c, m);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}