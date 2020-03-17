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

class MakingAnagrams
{
	// Complete the makingAnagrams function below.
	static int MakingAnagramsMethod(string s1, string s2)
	{
		HashSet<char> hashSet = new HashSet<char>();

		foreach (char c in s1 + s2)
			hashSet.Add(c);

		Dictionary<char, int> dic1 = new Dictionary<char, int>();
		Dictionary<char, int> dic2 = new Dictionary<char, int>();

		foreach (char c in hashSet)
		{
			dic1.Add(c, 0);
			dic2.Add(c, 0);
		}

		foreach (char c in s1)
			dic1[c]++;

		foreach (char c in s2)
			dic2[c]++;

		int result = 0;
		foreach (char c in hashSet)
			result += Math.Abs(dic1[c] - dic2[c]);

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string s1 = Console.ReadLine();
	// 	string s2 = Console.ReadLine();
	//
	// 	int result = MakingAnagramsMethod(s1, s2);
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}