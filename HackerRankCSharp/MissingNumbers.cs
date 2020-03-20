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

class MissingNumbers
{
	// Complete the missingNumbers function below.
	static int[] MissingNumbersMethod(int[] dataWithoutMissingItems, int[] originalData)
	{
		Dictionary<int, int> counts = new Dictionary<int, int>();
		foreach (var temp in originalData)
		{
			if (counts.ContainsKey(temp))
				counts[temp]++;
			else
				counts.Add(temp, 1);
		}

		foreach (var temp in dataWithoutMissingItems)
			counts[temp]--;

		return counts
		      .Where(x => x.Value != 0)
		      .OrderBy(x => x.Key)
		      .Select(x => x.Key)
		      .ToArray();
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		int[] dataWithoutMissingItems = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		int   m                       = Convert.ToInt32(Console.ReadLine());

		int[] originalData = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp));
		int[] result       = MissingNumbersMethod(dataWithoutMissingItems, originalData);

		textWriter.WriteLine(string.Join(" ", result));

		textWriter.Flush();
		textWriter.Close();
	}
}