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

class ClosestNumbers
{
	// Complete the closestNumbers function below.
	static int[] ClosestNumbersMethod(int[] arr)
	{
		Array.Sort(arr);

		int minDiff      = int.MaxValue;
		int minDiffPairs = 0;
		for (int i = 1; i < arr.Length; i++)
		{
			if (arr[i] - arr[i - 1] < minDiff)
			{
				minDiff      = arr[i] - arr[i - 1];
				minDiffPairs = 1;
			}
			else if (arr[i] - arr[i - 1] == minDiff)
			{
				minDiffPairs++;
			}
		}

		int   index  = 0;
		int[] result = new int[minDiffPairs * 2];
		for (int i = 0; i < arr.Length - 1; i++)
		{
			if (arr[i + 1] - arr[i] == minDiff)
			{
				result[index++] = arr[i];
				result[index++] = arr[i + 1];
			}
		}

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
	// 	int[] result = ClosestNumbersMethod(arr);
	//
	// 	textWriter.WriteLine(string.Join(" ", result));
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}