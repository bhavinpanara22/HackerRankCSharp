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

class PriyankaAndToys
{
	// Complete the toys function below.
	static int Toys(int[] w)
	{
		Array.Sort(w);

		int count = 0;
		for (int i = 0; i < w.Length;)
		{
			int compareTo = w[i];
			count++;

			i++;
			while (i < w.Length && w[i] <= compareTo + 4)
				i++;
		}

		return count;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int   n      = Convert.ToInt32(Console.ReadLine());
		int[] w      = Array.ConvertAll(Console.ReadLine().Split(' '), wTemp => Convert.ToInt32(wTemp));
		int   result = Toys(w);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}