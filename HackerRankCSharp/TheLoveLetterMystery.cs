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

class TheLoveLetterMystery
{
	// Complete the theLoveLetterMystery function below.
	static int TheLoveLetterMysteryMethod(string s)
	{
		int result = 0;

		for (int i = 0; i < s.Length / 2; i++)
			result += Math.Abs(s[i] - s[s.Length - i - 1]);

		return result;
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
	// 		int result = TheLoveLetterMysteryMethod(s);
	//
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}