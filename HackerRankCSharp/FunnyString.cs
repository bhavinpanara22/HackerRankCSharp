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

class FunnyString
{
	// Complete the funnyString function below.
	static string FunnyStringMethod(string s)
	{
		int[] diffs = new int[s.Length - 1];

		for (int i = 0; i < s.Length - 1; i++)
			diffs[i] = Math.Abs(s[i + 1] - s[i]);

		bool isFunny = true;
		for (int i = 0; i < diffs.Length / 2; i++)
		{
			if (diffs[i] != diffs[diffs.Length - i - 1])
				isFunny = false;
		}

		return isFunny ? "Funny" : "Not Funny";
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int q = Convert.ToInt32(Console.ReadLine());

		for (int qItr = 0; qItr < q; qItr++)
		{
			string s = Console.ReadLine();

			string result = FunnyStringMethod(s);
			textWriter.WriteLine(result);
		}

		textWriter.Flush();
		textWriter.Close();
	}
}