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
	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int t = Convert.ToInt32(Console.ReadLine());
		for (int tItr = 0; tItr < t; tItr++)
		{
			string[] nk = Console.ReadLine().Split(' ');
			int      n  = Convert.ToInt32(nk[0]);
			int      k  = Convert.ToInt32(nk[1]);

			if (k != 0)
			{
				if (n % k == 0 && (n / k) % 2 == 0)
				{
					for (int i = 1; i <= n; i++)
						textWriter.Write(i + ((i - 1) / k % 2 != 0 ? -k : k) + " ");
				}
				else
				{
					textWriter.Write("-1");
				}
			}
			else
			{
				for (int i = 1; i <= n; i++)
					textWriter.Write(i + " ");
			}

			textWriter.WriteLine();
		}

		textWriter.Flush();
		textWriter.Close();
	}
}