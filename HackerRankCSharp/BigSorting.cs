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

class BigSorting
{
	// Complete the bigSorting function below.
	static string[] BigSortingMethod(string[] unsorted)
	{
		Array.Sort(unsorted, (left, right) => left.Length == right.Length ? string.CompareOrdinal(left,right) : left.Length - right.Length);
		return unsorted;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		string[] unsorted = new string [n];

		for (int i = 0; i < n; i++)
		{
			string unsortedItem = Console.ReadLine();
			unsorted[i] = unsortedItem;
		}

		string[] result = BigSortingMethod(unsorted);

		textWriter.WriteLine(string.Join("\n", result));

		textWriter.Flush();
		textWriter.Close();
	}
}