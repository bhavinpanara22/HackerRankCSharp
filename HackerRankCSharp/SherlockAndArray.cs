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

class SherlockAndArray
{
	// Complete the balancedSums function below.
	static string BalancedSums(List<int> arr)
	{
		int total = arr.Sum();
		int left  = 0;

		foreach (var temp in arr)
		{
			if (total - temp == 2 * left)
				return "YES";

			left += temp;
		}

		return "NO";
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int T = Convert.ToInt32(Console.ReadLine().Trim());

		for (int TItr = 0; TItr < T; TItr++)
		{
			int n = Convert.ToInt32(Console.ReadLine().Trim());

			List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

			string result = BalancedSums(arr);

			textWriter.WriteLine(result);
		}

		textWriter.Flush();
		textWriter.Close();
	}
}