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

class Solution
{
	// Complete the marsExploration function below.
	static int MarsExplorationMethod(string s)
	{
		int result = 0;

		for (int i = 0; i < s.Length; i += 3)
		{
			if (s[i] != 'S')
				result++;
			if (s[i + 1] != 'O')
				result++;
			if (s[i + 2] != 'S')
				result++;
		}

		return result;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		string s = Console.ReadLine();

		int result = MarsExplorationMethod(s);

		textWriter.WriteLine(result);
		textWriter.Flush();
		textWriter.Close();
	}
}