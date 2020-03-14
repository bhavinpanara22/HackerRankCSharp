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

class ManasaAndStones
{
	// Complete the stones function below.
	static int[] Stones(int n, int a, int b)
	{
		int lowerLimit = Math.Min(a, b) * (n - 1);
		int upperLimit = Math.Max(a, b) * (n - 1);

		if (lowerLimit == upperLimit) 
			return new[] {a * (n - 1)};

		List<int> result = new List<int> {lowerLimit};

		int diff      = Math.Abs(a - b);
		int lastAdded = result[0];
		while (lastAdded + diff <= upperLimit)
		{
			result.Add(lastAdded + diff);
			lastAdded += diff;
		}

		return result.ToArray();
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int T = Convert.ToInt32(Console.ReadLine());

		for (int TItr = 0; TItr < T; TItr++)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());

			int[] result = Stones(n, a, b);

			textWriter.WriteLine(string.Join(" ", result));
		}

		textWriter.Flush();
		textWriter.Close();
	}
}