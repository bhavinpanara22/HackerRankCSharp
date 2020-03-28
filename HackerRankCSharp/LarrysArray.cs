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

class LarrysArray
{
	// Complete the larrysArray function below.
	static string LarrysArrayMethod(int[] a)
	{
		int n = a.Length;
		for (int i = 0; i < n - 2; i++)
		{
			int k1 = a[i], k2 = a[i + 1], k3 = a[i + 2];
			if (k2 < k1 && k2 < k3)
			{
				a[i + 1] = k3;
				a[i + 2] = k1;
				a[i]     = k2;
				i        = -1;
			}
			else if (k3 < k1 && k3 < k2)
			{
				a[i + 1] = k1;
				a[i + 2] = k2;
				a[i]     = k3;
				i        = -1;
			}
		}

		return a[n - 3] < a[n - 2] && a[n - 2] < a[n - 1] ? "YES" : "NO";
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int t = Convert.ToInt32(Console.ReadLine());

		for (int tItr = 0; tItr < t; tItr++)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			int[]  A      = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));
			string result = LarrysArrayMethod(A);

			textWriter.WriteLine(result);
		}

		textWriter.Flush();
		textWriter.Close();
	}
}