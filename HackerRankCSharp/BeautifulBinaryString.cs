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

class BeautifulBinaryString
{
	// Complete the beautifulBinaryString function below.
	static int BeautifulBinaryStringMethod(string b)
	{
		int result = 0;

		for (int i = 0; i < b.Length - 2; i++)
		{
			if (b[i] == '0' && b[i + 1] == '1' && b[i + 2] == '0')
			{
				result++;
				i += 2;
			}
		}

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	string b = Console.ReadLine();
	//
	// 	int result = BeautifulBinaryStringMethod(b);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}