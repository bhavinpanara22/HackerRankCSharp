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

class CavityMap
{
	// Complete the cavityMap function below.
	static string[] CavityMapMethod(string[] grid)
	{
		string[] result = new string[grid.Length];
		Array.Copy(grid, result, grid.Length);

		for (int i = 1; i < grid.Length - 1; i++)
		{
			for (int j = 1; j < grid[i].Length - 1; j++)
			{
				int me = int.Parse(grid[i][j].ToString());
				int top    = int.Parse(grid[i - 1][j].ToString());
				int bottom = int.Parse(grid[i + 1][j].ToString());
				int left   = int.Parse(grid[i][j - 1].ToString());
				int right  = int.Parse(grid[i][j + 1].ToString());

				if (me > top && me > bottom && me > left && me > right)
				{
					result[i] = result[i].Remove(j, 1);
					result[i] = result[i].Insert(j,"X");
				}
			}
		}

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int      n    = Convert.ToInt32(Console.ReadLine());
	// 	string[] grid = new string [n];
	//
	// 	for (int i = 0; i < n; i++)
	// 	{
	// 		string gridItem = Console.ReadLine();
	// 		grid[i] = gridItem;
	// 	}
	//
	// 	string[] result = CavityMapMethod(grid);
	//
	// 	textWriter.WriteLine(string.Join("\n", result));
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}