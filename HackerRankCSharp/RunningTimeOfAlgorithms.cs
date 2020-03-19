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

class RunningTimeOfAlgorithms
{
	// Complete the runningTime function below.
	static int RunningTime(int[] arr)
	{
		int shifts = 0;

		int n = arr.Length;
		for (int i = 1; i < n; i++)
		{
			for (int j = i - 1; j >= 0 && arr[j] > arr[j + 1]; j--)
			{
				int temp = arr[j + 1];
				arr[j + 1] = arr[j];
				arr[j]     = temp;

				shifts++;
			}
		}

		return shifts;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
	// 	int   result = RunningTime(arr);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}