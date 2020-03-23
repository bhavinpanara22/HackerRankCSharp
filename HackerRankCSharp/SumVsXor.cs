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

class SumVsXor
{
	// Complete the sumXor function below.
	static long SumXor(long n)
	{
		long result = 1;
		while (n > 0)
		{
			if (n % 2 == 0)
				result *= 2;

			n /= 2;
		}

		return result;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		long n = Convert.ToInt64(Console.ReadLine().Trim());

		long result = SumXor(n);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}