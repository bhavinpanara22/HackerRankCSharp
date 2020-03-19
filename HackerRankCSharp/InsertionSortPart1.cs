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

class InsertionSortPart1
{
	// Complete the insertionSort1 function below.
	static void InsertionSort1(int n, int[] arr)
	{
		int len  = arr.Length;
		int last = arr[len - 1];

		for (int i = len - 2; i >= 0; i--)
		{
			if (arr[i] > last)
			{
				arr[i + 1] = arr[i];
				if (i == 0)
				{
					PrintArray(arr);
					arr[i] = last;
				}
				PrintArray(arr);
			}
			else
			{
				arr[i + 1] = last;
				PrintArray(arr);
				return;
			}
		}
	}

	static void PrintArray(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
			Console.Write(arr[i] + (i != arr.Length - 1 ? " " : string.Empty));

		Console.WriteLine();
	}

	static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());

		int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		InsertionSort1(n, arr);
	}
}