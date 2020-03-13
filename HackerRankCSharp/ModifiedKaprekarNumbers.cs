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

class ModifiedKaprekarNumbers
{
    static void KaprekarNumbers(int p, int q)
    {
        bool isFound = false;

        while (p <= q)
        {
            if (IsKaprekar(p))
            {
                Console.Write(p + " ");
                isFound = true;
            }

            p++;
        }
        
        if(!isFound)
            Console.WriteLine("INVALID RANGE");
    }

    static bool IsKaprekar(long num)
    {
        long   squared = num * num;
        string str     = squared.ToString();
        string left    = str.Substring(0, str.Length / 2);
        string right   = str.Substring(str.Length / 2);

        int numL = (string.IsNullOrEmpty(left)) ? 0 : int.Parse(left);
        int numR = (string.IsNullOrEmpty(right)) ? 0 : int.Parse(right);

        return (numL + numR) == num;
    }

    static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine());
        int q = Convert.ToInt32(Console.ReadLine());

        KaprekarNumbers(p, q);
    }
}