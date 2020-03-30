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
using System.Runtime.CompilerServices;

class SherlockAndTheValidString
{
	// Complete the isValid function below.
	static string IsValid(string s)
	{
		if (s.Length == 1)
			return "YES";

		var cnt = new int[26];
		foreach (char ch in s)
			cnt[ch - 'a']++;

		var a = cnt.Where(temp => temp > 0).OrderBy(x => x).ToList();
		int d = a.Distinct().Count();

		if (d == 1)
			return "YES";

		if (d == 2)
		{
			if (a[0] == 1 && a[1] > 1)
				return "YES";

			if (a[a.Count - 1] == a[a.Count - 2] + 1 && a.Take(a.Count - 1).Distinct().Count() == 1)
				return "YES";
		}

		return "NO";
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string s = Console.ReadLine();
	//
	// 	string result = IsValid(s);
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}