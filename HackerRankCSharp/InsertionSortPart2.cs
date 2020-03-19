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

class InsertionSortPart2
{
	// Complete the insertionSort2 function below.
	static void InsertionSort2(int n, int[] arr)
	{
		for (int i = 1; i < n; i++)
		{
			for (int j = i - 1; j >= 0 && arr[j] > arr[j + 1]; j--)
			{
				int temp = arr[j + 1];
				arr[j + 1] = arr[j];
				arr[j]     = temp;
			}

			PrintArray(arr);
		}
	}

	static void PrintArray(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
			Console.Write(arr[i] + (i != arr.Length - 1 ? " " : string.Empty));

		Console.WriteLine();
	}

	// static void Main(string[] args)
	// {
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
	//
	// 	InsertionSort2(n, arr);
	// }
}