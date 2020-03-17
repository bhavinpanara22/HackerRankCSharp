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

class WeightedUniformStrings
{
	// Complete the weightedUniformStrings function below.
	static string[] WeightedUniformStringsMethod(string s, int[] queries)
	{
		HashSet<int> allWeights = new HashSet<int>();

		int  w    = 0;
		char prev = ' ';
		foreach (char ch in s)
		{
			if (ch != prev)
				w = 0;

			w += (ch - 'a') + 1;
			allWeights.Add(w);
			prev = ch;
		}

		string[] result = new string[queries.Length];
		for (int i = 0; i < queries.Length; i++)
			result[i] = allWeights.Contains(queries[i]) ? "Yes" : "No";

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string s = Console.ReadLine();
	//
	// 	int queriesCount = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[] queries = new int [queriesCount];
	//
	// 	for (int i = 0; i < queriesCount; i++)
	// 	{
	// 		int queriesItem = Convert.ToInt32(Console.ReadLine());
	// 		queries[i] = queriesItem;
	// 	}
	//
	// 	string[] result = WeightedUniformStringsMethod(s, queries);
	//
	// 	textWriter.WriteLine(string.Join("\n", result));
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}