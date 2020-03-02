using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class TimeConversion
{
    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s      = Console.ReadLine();
        string result = DateTime.Parse(s).ToString("HH:mm:ss");

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}