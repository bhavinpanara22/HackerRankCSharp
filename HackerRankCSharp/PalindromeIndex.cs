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

class PalindromeIndex
{
	// Complete the palindromeIndex function below.
	static int PalindromeIndexMethod(string s)
	{
		int i = 0, j = s.Length - 1;
		while (i < j)
		{
			if (s[i] == s[j])
			{
				i++;
				j--;
			}
			else
			{
				return IsPalindrome(s.Substring(i, j - i)) ? j : i;
			}
		}

		return -1;
	}

	static bool IsPalindrome(string s)
	{
		int i = 0, j = s.Length - 1;
		while (i < j)
		{
			if (s[i] == s[j])
			{
				i++;
				j--;
			}
			else
			{
				return false;
			}
		}

		return true;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int q = Convert.ToInt32(Console.ReadLine());

		for (int qItr = 0; qItr < q; qItr++)
		{
			string s = Console.ReadLine();

			int result = PalindromeIndexMethod(s);

			textWriter.WriteLine(result);
		}

		textWriter.Flush();
		textWriter.Close();
	}
}