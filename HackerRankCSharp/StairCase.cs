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

class StairCase
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string toWrite = string.Empty;
            for (int j = 0; j < n - i; j++)
                toWrite += " ";

            for (int j = 0; j < i; j++)
                toWrite += "#";

            Console.WriteLine(toWrite);
        }
    }
}