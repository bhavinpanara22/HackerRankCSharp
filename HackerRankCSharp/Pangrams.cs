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

class Pangrams
{
	// Complete the pangrams function below.
	static string PangramsMethod(string s)
	{
		char[] allChars = s.Replace(" ", string.Empty).ToLower().ToCharArray().Distinct().ToArray();
		return allChars.Length == 26 ? "pangram" : "not pangram";
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string s = Console.ReadLine();
	//
	// 	string result = PangramsMethod(s);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}