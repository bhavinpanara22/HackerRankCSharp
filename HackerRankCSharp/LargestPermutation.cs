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

class LargestPermutation
{
	// Complete the largestPermutation function below.
	static int[] LargestPermutationMethod(int k, int[] arr)
	{
		int   n   = arr.Length;
		int[] pos = new int[n + 1];

		for (int i = 0; i < n; i++)
			pos[arr[i]] = i;

		for (int i = 0; i < n && k > 0; i++)
		{
			if (arr[i] == n - i)
				continue;

			int temp = pos[n - i];
			pos[arr[i]] = pos[n - i];
			pos[n - i]  = i;

			int tmp1 = arr[temp];
			arr[temp] = arr[i];
			arr[i]    = tmp1;

			k--;
		}

		return arr;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string[] nk = Console.ReadLine().Split(' ');
	//
	// 	int   n      = Convert.ToInt32(nk[0]);
	// 	int   k      = Convert.ToInt32(nk[1]);
	// 	int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
	// 	int[] result = LargestPermutationMethod(k, arr);
	//
	// 	textWriter.WriteLine(string.Join(" ", result));
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}