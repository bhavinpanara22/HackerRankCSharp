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

class FindDigits
{
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n              = Convert.ToInt32(Console.ReadLine());
            int originalNumber = n;
            int result         = 0;

            while (n != 0)
            {
                int digit = n % 10;

                if (digit != 0 && originalNumber % digit == 0)
                    result++;

                n /= 10;
            }

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}