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

class MinimumAbsoluteDifferenceInAnArray
{
	// Complete the minimumAbsoluteDifference function below.
	static int MinimumAbsoluteDifference(int[] arr)
	{
		Array.Sort(arr);

		int minDiff = int.MaxValue;
		for (int i = 0; i < arr.Length - 1; i++)
		{
			int temp = Math.Abs(arr[i + 1] - arr[i]);
			minDiff = Math.Min(minDiff, temp);
		}

		return minDiff;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		int   result = MinimumAbsoluteDifference(arr);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}