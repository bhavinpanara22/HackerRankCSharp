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

class StrangeCounter
{
	// Complete the strangeCounter function below.
	static long StrangeCounterMethod(long t)
	{
		long rem = 3;
		while (t > rem)
		{
			t   -= rem;
			rem *= 2;
		}

		return rem - t + 1;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	long t      = Convert.ToInt64(Console.ReadLine());
	// 	long result = StrangeCounterMethod(t);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}