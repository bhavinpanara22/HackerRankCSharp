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

class CaesarCipher
{
	// Complete the caesarCipher function below.
	static string CaesarCipherMethod(string s, int k)
	{
		k %= 26;

		const int lowerTop = 122;
		const int upperTop = 90;

		string str = string.Empty;
		foreach (var ch in s)
		{
			int ascii = ch;

			if (char.IsUpper(ch))
			{
				ascii += k;

				if (ascii > upperTop)
					ascii -= 26;
			}
			else if (char.IsLower(ch))
			{
				ascii += k;

				if (ascii > lowerTop)
					ascii -= 26;
			}

			str += Convert.ToChar(ascii).ToString();
		}

		return str;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int    n = Convert.ToInt32(Console.ReadLine());
		string s = Console.ReadLine();
		int    k = Convert.ToInt32(Console.ReadLine());

		string result = CaesarCipherMethod(s, k);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}