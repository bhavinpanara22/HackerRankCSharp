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

class AlmostSorted
{
	// Complete the almostSorted function below.
	static string AlmostSortedMethod(int[] arr)
	{
		// find the first index from start & end that breaks the sorting rule.
		int leftIndex = -1, rightIndex = -1;
		for (int i = 0; i < arr.Length - 1; i++)
		{
			if (arr[i] > arr[i + 1])
			{
				leftIndex = i;
				break;
			}
		}

		for (int i = arr.Length - 1; i >= 0; i--)
		{
			if (arr[i] < arr[i - 1])
			{
				rightIndex = i;
				break;
			}
		}

		// if already sorted
		if (leftIndex == -1 && rightIndex == -1)
			return "yes";

		// try swapping & check if sorted
		Swap(arr, leftIndex, rightIndex);

		bool isSortedBySwap = true;
		for (int i = 0; i < arr.Length - 1; i++)
		{
			if (arr[i] < arr[i + 1])
				continue;

			isSortedBySwap = false;
			break;
		}

		if (isSortedBySwap)
			return "yes\n" + "swap " + (leftIndex + 1) + " " + (rightIndex + 1);

		// back to the original array by swapping again
		Swap(arr, leftIndex, rightIndex);

		// now try reversing and check if sorted
		for (int i = leftIndex; i <= (rightIndex + leftIndex) / 2; i++)
			Swap(arr, i, rightIndex + leftIndex - i);

		bool isSortedByReverse = true;
		for (int i = 0; i < arr.Length - 1; i++)
		{
			if (arr[i] < arr[i + 1])
				continue;

			isSortedByReverse = false;
			break;
		}

		if (isSortedByReverse)
			return "yes\n" + "reverse " + (leftIndex + 1) + " " + (rightIndex + 1);

		return "no";
	}

	static void Swap(int[] arr, int i, int j)
	{
		int temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
	}

	// static void Main(string[] args)
	// {
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[]  arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
	// 	string result = AlmostSortedMethod(arr);
	// 	Console.WriteLine(result);
	// }
}