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

class IceCreamParlor
{
	// Complete the icecreamParlor function below.
	static int[] IceCreamParlorMethod(int m, int[] arr)
	{
		int[] sorted = new int[arr.Length];
		Array.Copy(arr, sorted, arr.Length);
		Array.Sort(sorted);

		int[] result = new int[2];
		for (int i = 0; i < sorted.Length; i++)
		{
			int complement      = m - sorted[i];
			int complementIndex = Array.BinarySearch(sorted, i + 1, sorted.Length - i - 1, complement);
			if (complementIndex >= 0)
			{
				int index1 = FindIndex(arr, sorted[i], -1);
				int index2 = FindIndex(arr, complement, index1);
				result = new[] {Math.Min(index1, index2) + 1, Math.Max(index1, index2) + 1};
				break;
			}
		}

		return result;
	}

	static int FindIndex(int[] arr, int value, int indexToExclude)
	{
		int index = -1;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == value && i != indexToExclude)
			{
				index = i;
				break;
			}
		}

		return index;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int t = Convert.ToInt32(Console.ReadLine());

		for (int tItr = 0; tItr < t; tItr++)
		{
			int m = Convert.ToInt32(Console.ReadLine());
			int n = Convert.ToInt32(Console.ReadLine());

			int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
			int[] result = IceCreamParlorMethod(m, arr);

			textWriter.WriteLine(string.Join(" ", result));
		}

		textWriter.Flush();
		textWriter.Close();
	}
}