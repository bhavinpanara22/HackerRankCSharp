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

class SherlockAndTheBeast
{
	// Complete the decentNumber function below.
	static void DecentNumber(int n)
	{
		int c = 5 * ((2 * n) % 3);
		if (c > n)
			Console.WriteLine("-1");
		else
			Console.WriteLine(new string('5', n - c) + new string('3', c));
	}

	// static void Main(string[] args)
	// {
	// 	int t = Convert.ToInt32(Console.ReadLine().Trim());
	//
	// 	for (int tItr = 0; tItr < t; tItr++)
	// 	{
	// 		int n = Convert.ToInt32(Console.ReadLine().Trim());
	// 		DecentNumber(n);
	// 	}
	// }
}