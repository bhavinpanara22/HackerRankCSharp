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

class Anagram
{
	// Complete the anagram function below.
	static int AnagramMethod(string s)
	{
		if (s.Length % 2 == 1)
			return -1;

		string alpha  = "abcdefghijklmnopqrstuvwxyz";
		int[]  count1 = new int[26];
		int[]  count2 = new int[26];
		int    len    = s.Length / 2;
		for (int i = 0; i < len; i++)
		{
			count1[alpha.IndexOf(s[i])]++;
			count2[alpha.IndexOf(s[i + len])]++;
		}

		int count = 0;
		for (int i = 0; i < 26; i++)
			count += Math.Abs(count2[i] - count1[i]);

		return count / 2;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int q = Convert.ToInt32(Console.ReadLine());
	//
	// 	for (int qItr = 0; qItr < q; qItr++)
	// 	{
	// 		string s = Console.ReadLine();
	//
	// 		int result = AnagramMethod(s);
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}