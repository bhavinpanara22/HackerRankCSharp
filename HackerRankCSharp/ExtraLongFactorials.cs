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
using System.Numerics;

class ExtraLongFactorials
{
	// Complete the extraLongFactorials function below.
	static void ExtraLongFactorialsMethod(int n)
	{
		Console.WriteLine(BigFactorial(n));
	}

	static BigInteger BigFactorial(int n)
	{
		if (n <= 1)
			return 1;

		return n * BigFactorial(n - 1);
	}

	// static void Main(string[] args)
	// {
	// 	int n = Convert.ToInt32(Console.ReadLine());
	// 	ExtraLongFactorialsMethod(n);
	// }
}