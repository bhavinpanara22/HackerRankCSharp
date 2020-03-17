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

class SeparateTheNumbers
{
	static void Main(string[] args)
	{
		int q = Convert.ToInt32(Console.ReadLine());

		for (int qItr = 0; qItr < q; qItr++)
		{
			string s     = Console.ReadLine();
			bool   valid = false;

			long firstx = -1;

			// Try each possible starting number
			for (int i = 1; i <= s.Length / 2; i++)
			{
				long x = long.Parse(s.Substring(0, i));
				firstx = x;

				// Build up sequence starting with this number
				string test = x.ToString();
				while (test.Length < s.Length)
				{
					test += (++x).ToString();
				}

				// Compare to original
				if (test.Equals(s))
				{
					valid = true;
					break;
				}
			}

			Console.WriteLine(valid ? "YES " + firstx : "NO");
		}
	}
}