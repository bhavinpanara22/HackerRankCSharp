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

class FlippingBits
{
	// Complete the flippingBits function below.
	static long FlippingBitsMethod(long n)
	{
		return ~((uint) n);
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int q = Convert.ToInt32(Console.ReadLine());
	//
	// 	for (int qItr = 0; qItr < q; qItr++)
	// 	{
	// 		long n      = Convert.ToInt64(Console.ReadLine());
	// 		long result = FlippingBitsMethod(n);
	//
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}