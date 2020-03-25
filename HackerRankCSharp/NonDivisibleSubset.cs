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

class ResultNDS
{
	/*
	 * Complete the 'nonDivisibleSubset' function below.
	 *
	 * The function is expected to return an INTEGER.
	 * The function accepts following parameters:
	 *  1. INTEGER k
	 *  2. INTEGER_ARRAY s
	 */

	public static int NonDivisibleSubsetMethod(int k, List<int> s)
	{
		int[] arr = new int[k];
		foreach (var temp in s)
			arr[temp % k]++;

		int result = 0;
		if (k % 2 == 0)
			result++;

		result += Math.Min(arr[0], 1);
		for (int j = 1; j <= k / 2; j++)
		{
			if (j != k - j)
				result += Math.Max(arr[j], arr[k - j]);
		}

		return result;
	}
}

class NonDivisibleSubset
{
	// public static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
	//
	// 	int       n = Convert.ToInt32(firstMultipleInput[0]);
	// 	int       k = Convert.ToInt32(firstMultipleInput[1]);
	// 	List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
	//
	// 	int result = ResultNDS.NonDivisibleSubsetMethod(k, s);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}