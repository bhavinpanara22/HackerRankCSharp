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
using Microsoft.VisualBasic;

class Encryption
{
	// Complete the encryption function below.
	static string EncryptionMethod(string s)
	{
		s = s.Replace(" ", "");
		int columns = (int) Math.Ceiling(Math.Sqrt(s.Length));

		StringBuilder result = new StringBuilder(string.Empty);
		for (int i = 0; i < columns; i++)
		{
			for (int j = i; j < s.Length; j += columns)
				result.Append(s[j]);

			if (i != columns - 1)
				result.Append(" ");
		}

		return result.ToString();
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string s      = Console.ReadLine();
	// 	string result = EncryptionMethod(s);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}