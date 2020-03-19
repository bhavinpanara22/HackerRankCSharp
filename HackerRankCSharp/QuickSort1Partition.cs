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

class QuickSort1Partition
{
	// Complete the quickSort function below.
	static int[] Partition(int[] arr)
	{
		int i     = 0, j = arr.Length - 1;
		int pivot = arr[0];

		while (i < j)
		{
			while (arr[i] <= pivot)
				i++;

			while (arr[j] > pivot)
				j--;

			if (i < j)
			{
				int temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}
		}

		arr[0] = arr[j];
		arr[j] = pivot;

		return arr;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

		int[] result = Partition(arr);

		textWriter.WriteLine(string.Join(" ", result));

		textWriter.Flush();
		textWriter.Close();
	}
}