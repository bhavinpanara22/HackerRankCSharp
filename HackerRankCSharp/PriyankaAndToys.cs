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
		int result = 0;
		int[] counts = new int[10000];

		foreach (var temp in w)
			counts[temp]++;

		for (int i = 0; i < 10000; i++)
		{
			if (counts[i] != 0)
			{
				result++;
				i += 4;
			}
		}

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int   n      = Convert.ToInt32(Console.ReadLine());
	// 	int[] w      = Array.ConvertAll(Console.ReadLine().Split(' '), wTemp => Convert.ToInt32(wTemp));
	// 	int   result = Toys(w);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}