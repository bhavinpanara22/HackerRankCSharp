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

class BeautifulPairs
{
	// Complete the beautifulPairs function below.
	static int BeautifulPairsMethod(int[] A, int[] B)
	{
		int                  pairs  = 0;
		Dictionary<int, int> countA = CountOccurence(A);
		Dictionary<int, int> countB = CountOccurence(B);

		foreach (var pair in countA)
		{
			if (countB.ContainsKey(pair.Key))
				pairs += Math.Min(pair.Value, countB[pair.Key]);
		}

		if (pairs == A.Length)
			pairs--;
		else
			pairs++;

		return pairs;
	}

	static Dictionary<int, int> CountOccurence(int[] arr)
	{
		Dictionary<int, int> result = new Dictionary<int, int>();
		foreach (var temp in arr)
		{
			if (result.ContainsKey(temp))
				result[temp]++;
			else
				result.Add(temp, 1);
		}

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[] A      = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));
	// 	int[] B      = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));
	// 	int   result = BeautifulPairsMethod(A, B);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}