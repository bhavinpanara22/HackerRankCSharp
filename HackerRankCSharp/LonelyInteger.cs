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

class LonelyInteger
{
	// Complete the lonelyinteger function below.
	static int LonelyIntegerMethod(int[] a)
	{
		int res = 0;

		foreach (var temp in a)
			res ^= temp;

		return res;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		int[] a      = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
		int   result = LonelyIntegerMethod(a);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}