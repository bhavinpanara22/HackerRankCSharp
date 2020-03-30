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

class SherlockAndAnagrams
{
	// Complete the sherlockAndAnagrams function below.
	static int SherlockAndAnagramsMethod(string s)
	{
		var count = 0;

		for (int len = 1; len < s.Length; len++)
		{
			for (int i = 0; i <= s.Length - len; i++)
			{
				string sub1 = s.Substring(i, len);
				for (int j = i + 1; j <= s.Length - len; j++)
				{
					string sub2 = s.Substring(j, len);
					if (IsAnagram(sub1, sub2))
						count++;
				}
			}
		}

		return count;
	}

	static bool IsAnagram(string str1, string str2)
	{
		int[] count = new int[26];

		int len = str1.Length;
		for (int i = 0; i < len; i++)
		{
			count[str1[i] - 'a']++;
			count[str2[i] - 'a']--;
		}

		return count.All(temp => temp == 0);
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int q = Convert.ToInt32(Console.ReadLine());
	// 	for (int qItr = 0; qItr < q; qItr++)
	// 	{
	// 		string s = Console.ReadLine();
	//
	// 		int result = SherlockAndAnagramsMethod(s);
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}