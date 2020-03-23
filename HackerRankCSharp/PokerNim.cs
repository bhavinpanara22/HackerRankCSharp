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

class PokerNim
{
	// Complete the pokerNim function below.
	static string PokerNimMethod(int k, int[] c)
	{
		int xor = 0;
		foreach (var temp in c)
			xor ^= temp;

		return xor == 0 ? "Second" : "First";
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int t = Convert.ToInt32(Console.ReadLine());

		for (int tItr = 0; tItr < t; tItr++)
		{
			string[] nk = Console.ReadLine().Split(' ');

			int n = Convert.ToInt32(nk[0]);
			int k = Convert.ToInt32(nk[1]);

			int[]  c      = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
			string result = PokerNimMethod(k, c);

			textWriter.WriteLine(result);
		}

		textWriter.Flush();
		textWriter.Close();
	}
}