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

class BeautifulDaysAtTheMovies
{
    // Complete the beautifulDays function below.
    static int BeautifulDays(int i, int j, int k)
    {
        int result = 0;
        for (; i <= j; i++)
        {
            if (Math.Abs(i - ReverseInt(i)) % k == 0)
                result++;
        }

        return result;
    }

    static int ReverseInt(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result =  (result * 10) + (num % 10);
            num    /= 10;
        }

        return result;
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] ijk = Console.ReadLine().Split(' ');

        int i = Convert.ToInt32(ijk[0]);
        int j = Convert.ToInt32(ijk[1]);
        int k = Convert.ToInt32(ijk[2]);

        int result = BeautifulDays(i, j, k);

        Console.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}