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

class GameOfThronesI
{
	// Complete the gameOfThrones function below.
	static string GameOfThrones(string s)
	{
		Dictionary<char, int> dic1 = new Dictionary<char, int>();

		var allChars = s.ToCharArray().Distinct();
		foreach (char ch in allChars)
			dic1.Add(ch, 0);

		foreach (char ch in s)
			dic1[ch]++;

		int oddChars = 0;
		foreach (var temp in dic1)
		{
			if (temp.Value % 2 == 1)
				oddChars++;
		}

		return oddChars > 1 ? "NO" : "YES";
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string s = Console.ReadLine();
	//
	// 	string result = GameOfThrones(s);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}