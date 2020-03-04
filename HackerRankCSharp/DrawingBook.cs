using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class DrawingBook
{
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());

        int front  = p / 2;
        int back   = (n / 2) - front;
        int result = Math.Min(front, back);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}