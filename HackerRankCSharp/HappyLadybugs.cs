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

class HappyLadybugs
{
	// Complete the happyLadybugs function below.
	static string HappyLadybugsMethod(string b)
	{
		if (b.Length == 1)
			return b[0] == '_' ? "YES" : "NO";

		if (b.Contains("_") == false)
		{
			for (int i = 0; i < b.Length; i++)
			{
				if ((i - 1 >= 0 && b[i] == b[i - 1]) || (i + 1 < b.Length && b[i] == b[i + 1]))
					continue;
				return "NO";
			}
			
			return "YES";
		}

		Dictionary<char, int> myDictionary = new Dictionary<char, int>();
		foreach (char temp in b)
		{
			if (temp != '_')
			{
				if (myDictionary.ContainsKey(temp) == false)
					myDictionary.Add(temp, 1);
				else
					myDictionary[temp]++;
			}
		}

		return myDictionary.Any(temp => temp.Value == 1) ? "NO" : "YES";
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int g = Convert.ToInt32(Console.ReadLine());

		for (int gItr = 0; gItr < g; gItr++)
		{
			int    n = Convert.ToInt32(Console.ReadLine());
			string b = Console.ReadLine();

			string result = HappyLadybugsMethod(b);

			textWriter.WriteLine(result);
		}

		textWriter.Flush();
		textWriter.Close();
	}
}