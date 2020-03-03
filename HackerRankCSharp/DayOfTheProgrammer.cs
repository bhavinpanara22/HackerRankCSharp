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

class DayOfTheProgrammer
{
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        DateTime startTime = new DateTime(year: year, month: 1, day: 1);
        if (year < 1918)
        {
            startTime = startTime.AddDays(255);

            if (year % 100 == 0)
                startTime = startTime.AddDays(-1);
        }
        else if (year >= 1918)
        {
            startTime = startTime.AddDays((year == 1918) ? 268 : 255);
        }

        textWriter.WriteLine(startTime.ToString("dd.MM.yyyy"));

        textWriter.Flush();
        textWriter.Close();
    }
}