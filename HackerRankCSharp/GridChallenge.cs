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

class GridChallenge
{
	// Complete the gridChallenge function below.
	static string GridChallengeMethod(string[] grid)
	{
		for (int i = 0; i < grid.Length; i++)
		{
			var allChars = grid[i].OrderBy(c => c).ToArray();
			grid[i] = new string(allChars);
		}

		int len = grid[0].Length;
		for (int col = 0; col < len; col++)
		{
			for (int row = 0; row < grid.Length - 1; row++)
			{
				char x = grid[row][col];
				char y = grid[row + 1][col];
				if (x > y)
					return "NO";
			}
		}

		return "YES";
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int t = Convert.ToInt32(Console.ReadLine());
	//
	// 	for (int tItr = 0; tItr < t; tItr++)
	// 	{
	// 		int      n    = Convert.ToInt32(Console.ReadLine());
	// 		string[] grid = new string [n];
	//
	// 		for (int i = 0; i < n; i++)
	// 		{
	// 			string gridItem = Console.ReadLine();
	// 			grid[i] = gridItem;
	// 		}
	//
	// 		string result = GridChallengeMethod(grid);
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}