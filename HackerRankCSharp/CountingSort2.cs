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

class CountingSort2
{
	// Complete the countingSort function below.
	static int[] CountingSort(int[] arr)
	{
		int[] counts = new int[100];
		foreach (int temp in arr)
			counts[temp]++;

		int index = 0;
		for (int i = 0; i < counts.Length; i++)
		{
			for (int j = 0; j < counts[i]; j++)
			{
				arr[index] = i;
				index++;
			}
		}

		return arr;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		int[] result = CountingSort(arr);

		textWriter.WriteLine(string.Join(" ", result));

		textWriter.Flush();
		textWriter.Close();
	}
}