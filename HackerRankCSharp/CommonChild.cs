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

class CommonChild
{
	// Complete the commonChild function below.
	static int CommonChildMethod(string s1, string s2)
	{
		int[,] check        = new int[s1.Length + 1, s2.Length + 1];
		var    s1Characters = s1.ToCharArray();
		var    s2Characters = s2.ToCharArray();

		for (int i = 0; i < s1.Length; i++)
		{
			for (int j = 0; j < s2.Length; j++)
			{
				if (s1Characters[i] == s2Characters[j])
					check[i + 1, j + 1] = check[i, j] + 1;
				else
					check[i + 1, j + 1] = Math.Max(check[i + 1, j], check[i, j + 1]);
			}
		}

		return check[s1.Length, s2.Length];
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string s1 = Console.ReadLine();
	// 	string s2 = Console.ReadLine();
	//
	// 	int result = CommonChildMethod(s1, s2);
	// 	textWriter.WriteLine(result);
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}