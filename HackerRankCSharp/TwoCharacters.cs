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

class TwoCharacters
{
	// Complete the alternate function below.
	static int Alternate(string s)
	{
		char[] allChars = s.ToCharArray().Distinct().ToArray();
		if (allChars.Length == 1)
			return 0;

		int result = 0;
		for (int i = 0; i < allChars.Length - 1; i++)
		{
			for (int j = i + 1; j < allChars.Length; j++)
			{
				string tempString = s.Where(ch => ch == allChars[i] || ch == allChars[j]).Aggregate(string.Empty, (current, ch) => current + ch);

				if (tempString.Length <= 1)
					continue;

				bool isAlternate = true;
				for (int k = 0; k < tempString.Length - 2; k++)
				{
					if (tempString[k] != tempString[k + 2])
					{
						isAlternate = false;
						break;
					}
				}

				if (isAlternate)
					result = Math.Max(result, tempString.Length);
			}
		}

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int    l = Convert.ToInt32(Console.ReadLine().Trim());
	// 	string s = Console.ReadLine();
	//
	// 	int result = Alternate(s);
	//
	// 	textWriter.WriteLine(result);
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}