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

class NimbleGame
{
	// Complete the nimbleGame function below.
	static string NimbleGameMethod(int[] s)
	{
		int xor = 0;
		for (int i = 0; i < s.Length; i++)
		{
			if (s[i] % 2 == 1)
				xor ^= i;
		}

		return xor == 0 ? "Second" : "First";
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int t = Convert.ToInt32(Console.ReadLine());
	//
	// 	for (int tItr = 0; tItr < t; tItr++)
	// 	{
	// 		int n = Convert.ToInt32(Console.ReadLine());
	//
	// 		int[]  s      = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
	// 		string result = NimbleGameMethod(s);
	//
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}