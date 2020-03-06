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

class DesignerPDFViewer
{
    // Complete the designerPdfViewer function below.
    static int DesignerPdfViewer(int[] h, string word)
    {
        int width = word.Length, maxHeight = 0;

        foreach (char c in word)
        {
            if (h[c - 97] > maxHeight)
                maxHeight = h[c - 97];
        }

        return width * maxHeight;
    }

    // static void Main(string[] args)
    // {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     int[]  h    = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
    //     string word = Console.ReadLine();
    //
    //     int result = DesignerPdfViewer(h, word);
    //
    //     textWriter.WriteLine(result);
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}