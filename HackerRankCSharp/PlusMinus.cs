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

class PlusMinusClass
{
    // Complete the plusMinus function below.
    static void PlusMinus(int[] arr)
    {
        int pos = 0, neg = 0, zero = 0;
        foreach (var temp in arr)
        {
            if (temp > 0)
                pos++;
            else if (temp < 0)
                neg++;
            else
                zero++;
        }

        Console.WriteLine((float) pos / arr.Length);
        Console.WriteLine((float) neg / arr.Length);
        Console.WriteLine((float) zero / arr.Length);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        PlusMinus(arr);
    }
}