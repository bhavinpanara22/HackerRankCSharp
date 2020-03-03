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

class BreakingTheRecords
{
    // Complete the breakingRecords function below.
    static int[] BreakingRecords(int[] scores)
    {
        int[] recordBreaks = {0, 0};

        int lowest  = scores[0];
        int highest = scores[0];
        foreach (var score in scores)
        {
            if (score > highest)
            {
                highest = score;
                recordBreaks[0]++;
            }

            if (score < lowest)
            {
                lowest = score;
                recordBreaks[1]++;
            }
        }

        return recordBreaks;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
        int[] result = BreakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));
        textWriter.Flush();
        textWriter.Close();
    }
}