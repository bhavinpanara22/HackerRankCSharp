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

class AbsolutePermutation
{
	static int[] AbsolutePermutationMethod(int n, int k)
	{
		int[] per        = new int[n];
		int   multiplier = 1;
		for (int i = 0, j = 0; i < n; i++, j++)
		{
			if (j == k)
			{
				multiplier *= -1;
				j          =  0;
			}

			int value = i + 1 + (k * multiplier);
			if (value < 1 || value > n)
				return new[] {-1};

			per[i] = value;
		}

		return per;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int t = Convert.ToInt32(Console.ReadLine());
		for (int tItr = 0; tItr < t; tItr++)
		{
			string[] nk = Console.ReadLine().Split(' ');
			int      n  = Convert.ToInt32(nk[0]);
			int      k  = Convert.ToInt32(nk[1]);

			int[] result = AbsolutePermutationMethod(n, k);
			textWriter.WriteLine(string.Join(" ", result));
		}

		textWriter.Flush();
		textWriter.Close();
	}
}