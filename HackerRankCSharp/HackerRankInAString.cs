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

class HackerRankInAString
{
	// Complete the hackerrankInString function below.
	static string HackerrankInString(string s)
	{
		const string str = "hackerrank";

		if (s.Length < str.Length)
			return "NO";

		int count = 0;
		foreach (var ch in s.Where(ch => (count < str.Length) && (ch == str[count])))
		{
			count++;
		}

		return str.Length == count ? "YES" : "NO";
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int q = Convert.ToInt32(Console.ReadLine());

		for (int qItr = 0; qItr < q; qItr++)
		{
			string s      = Console.ReadLine();
			string result = HackerrankInString(s);

			textWriter.WriteLine(result);
		}

		textWriter.Flush();
		textWriter.Close();
	}
}