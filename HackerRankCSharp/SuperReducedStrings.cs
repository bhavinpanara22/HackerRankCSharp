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

class SuperReducedStrings
{
	// Complete the superReducedString function below.
	// aaabccddd → abccddd → abddd → abd
	static string SuperReducedString(string s)
	{
		for (int i = 1; i < s.Length; i++)
		{
			if (s[i] == s[i - 1])
			{
				s = s.Substring(0, i - 1) + s.Substring(i + 1);
				i = 0;
			}
		}

		return s.Length == 0 ? "Empty String" : s;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string s = Console.ReadLine();
	//
	// 	string result = SuperReducedString(s);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}