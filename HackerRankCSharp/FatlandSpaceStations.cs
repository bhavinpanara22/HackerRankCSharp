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

class FatlandSpaceStations
{
    // Sample Input 0
    //
    // 5 2
    // 0 4
    // Sample Output 0
    //
    // 2

    static int FlatlandSpaceStationsMethod(int n, int[] c)
    {
        if (n == c.Length)
            return 0;
        
        if (c.Length == 1)
            return Math.Max(n - c[0] - 1, c[0]);

        Array.Sort(c);

        int max = c[0];
        for (int i = 0; i < c.Length; i++)
        {
            int tempMax = 0;
            if (i == (c.Length - 1))
                tempMax = n - c[i] - 1;
            else
                tempMax = (c[i + 1] - c[i]) / 2;
            
            max = Math.Max(max, tempMax);
        }

        return max;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');
        int      n  = Convert.ToInt32(nm[0]);
        int      m  = Convert.ToInt32(nm[1]);
        int[]    c  = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

        int result = FlatlandSpaceStationsMethod(n, c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}