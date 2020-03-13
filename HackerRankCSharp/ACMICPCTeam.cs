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

class ACMICPCTeam
{
    // Complete the acmTeam function below.
    static int[] AacmTeam(string[] topic)
    {
        int maxTopics      = 0;
        int maxTopicGroups = 0;

        int maxLength = topic[0].Length;
        for (int i = 0; i < topic.Length; i++)
        {
            for (int j = i + 1; j < topic.Length; j++)
            {
                int maxTopicsThisPair = 0;
                for (int k = 0; k < maxLength; k++)
                {
                    if (topic[i][k] == '1' || topic[j][k] == '1')
                        maxTopicsThisPair++;
                }

                if (maxTopicsThisPair > maxTopics)
                {
                    maxTopics      = maxTopicsThisPair;
                    maxTopicGroups = 1;
                }
                else if (maxTopicsThisPair == maxTopics)
                {
                    maxTopicGroups++;
                }
            }
        }

        return new[] {maxTopics, maxTopicGroups};
    }

    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     string[] nm = Console.ReadLine().Split(' ');
    //
    //     int n = Convert.ToInt32(nm[0]);
    //     int m = Convert.ToInt32(nm[1]);
    //
    //     string[] topic = new string [n];
    //
    //     for (int i = 0; i < n; i++)
    //     {
    //         string topicItem = Console.ReadLine();
    //         topic[i] = topicItem;
    //     }
    //
    //     int[] result = AacmTeam(topic);
    //
    //     textWriter.WriteLine(string.Join("\n", result));
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}