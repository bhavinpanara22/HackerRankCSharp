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

class TheGridSearch
{
	// Complete the gridSearch function below.
	static string GridSearch(string[] grid, string[] pattern)
	{
		for (int i = 0; i <= grid.Length - pattern.Length; i++)
		{
			for (int j = 0; j <= grid[i].Length - pattern[0].Length; j++)
			{
				if (grid[i][j] != pattern[0][0] || grid[i].Substring(j, pattern[0].Length) != pattern[0])
					continue;

				bool isFound = !pattern.Where((t, k) => grid[i + k].Substring(j, t.Length) != t).Any();
				if (isFound)
					return "YES";
			}
		}

		return "NO";
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int t = Convert.ToInt32(Console.ReadLine());
	//
	// 	for (int tItr = 0; tItr < t; tItr++)
	// 	{
	// 		string[] RC = Console.ReadLine().Split(' ');
	// 		int      R  = Convert.ToInt32(RC[0]);
	// 		int      C  = Convert.ToInt32(RC[1]);
	//
	// 		string[] grid = new string [R];
	// 		for (int i = 0; i < R; i++)
	// 		{
	// 			string GItem = Console.ReadLine();
	// 			grid[i] = GItem;
	// 		}
	//
	// 		string[] rc = Console.ReadLine().Split(' ');
	// 		int      r  = Convert.ToInt32(rc[0]);
	// 		int      c  = Convert.ToInt32(rc[1]);
	//
	// 		string[] pattern = new string [r];
	// 		for (int i = 0; i < r; i++)
	// 		{
	// 			string PItem = Console.ReadLine();
	// 			pattern[i] = PItem;
	// 		}
	//
	// 		string result = GridSearch(grid, pattern);
	//
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}