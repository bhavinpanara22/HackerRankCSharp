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

class StrongPassword
{
	// Complete the minimumNumber function below.
	static int MinimumNumber(int n, string password)
	{
		string specials = "!@#$%^&*()-+";

		int result = 0;
		if (password.Any(char.IsDigit) == false)
			result++;

		if (password.Any(char.IsLower) == false)
			result++;

		if (password.Any(char.IsUpper) == false)
			result++;

		if (password.Any(temp => specials.Contains(temp)) == false)
			result++;

		return Math.Max(6 - n, result);
	}

	static void Main(string[] args)
	{
		// TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int    n        = Convert.ToInt32(Console.ReadLine());
		string password = Console.ReadLine();

		int answer = MinimumNumber(n, password);

		Console.WriteLine(answer);

		// textWriter.Flush();
		// textWriter.Close();
	}
}