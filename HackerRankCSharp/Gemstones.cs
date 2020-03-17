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

class Gemstones
{
	// Complete the gemstones function below.
	static int GemstonesMethod(string[] arr)
	{
		char[] distinctChars = arr[0].ToCharArray().Distinct().ToArray();

		int gemstones = 0;
		foreach (char ch in distinctChars)
		{
			bool containsThisCharInAllStrings = true;
			foreach (string s in arr)
			{
				if (!s.Contains(ch))
					containsThisCharInAllStrings = false;
			}

			if (containsThisCharInAllStrings)
				gemstones++;
		}

		return gemstones;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		string[] arr = new string [n];

		for (int i = 0; i < n; i++)
		{
			string arrItem = Console.ReadLine();
			arr[i] = arrItem;
		}

		int result = GemstonesMethod(arr);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}