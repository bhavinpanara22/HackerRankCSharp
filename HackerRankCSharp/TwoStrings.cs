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

class TwoStrings
{
	// Complete the twoStrings function below.
	static string TwoStringsMethod(string s1, string s2)
	{
		const string letters = "abcdefghijklmnopqrstuvwxyz";
		return letters.Any(ch => s1.Contains(ch) && s2.Contains(ch)) ? "YES" : "NO";
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int q = Convert.ToInt32(Console.ReadLine());
	//
	// 	for (int qItr = 0; qItr < q; qItr++)
	// 	{
	// 		string s1 = Console.ReadLine();
	// 		string s2 = Console.ReadLine();
	//
	// 		string result = TwoStringsMethod(s1, s2);
	//
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}