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
using System.Runtime.CompilerServices;

class FormingAMagicSquare
{
	// Complete the formingMagicSquare function below.
	static int FormingMagicSquare(int[][] s)
	{
		int[][] allMagics =
		{
			new[] {8, 1, 6, 3, 5, 7, 4, 9, 2},
			new[] {6, 1, 8, 7, 5, 3, 2, 9, 4},
			new[] {4, 9, 2, 3, 5, 7, 8, 1, 6},
			new[] {2, 9, 4, 7, 5, 3, 6, 1, 8},
			new[] {8, 3, 4, 1, 5, 9, 6, 7, 2},
			new[] {4, 3, 8, 9, 5, 1, 2, 7, 6},
			new[] {6, 7, 2, 1, 5, 9, 8, 3, 4},
			new[] {2, 7, 6, 9, 5, 1, 4, 3, 8}
		};

		List<int> matrix = s.SelectMany(temp => temp).ToList();

		int cost = allMagics.Select(t1 => matrix.Select((t, j) => Math.Abs(t1[j] - t)).Sum()).Concat(new[] {int.MaxValue}).Min();
		return cost;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int[][] s = new int[3][];
	//
	// 	for (int i = 0; i < 3; i++)
	// 	{
	// 		s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
	// 	}
	//
	// 	int result = FormingMagicSquare(s);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}