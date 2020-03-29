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

class TheBomberManGame
{
	// Complete the bomberMan function below.
	static string[] BomberMan(int n, string[] grid)
	{
		// patterns are repeating every 4 seconds
		// this repetition starts only after 3rd second has passed.
		// 1,2,3,4,5,6....
		// 1 is same as input
		// all even has all bombs 'O'
		// 3 & 5 are different
		// 7,11,15,19....... are same as 3
		// 9,13,17,21....... are same as 5

		if (n == 1)
		{
			ReplaceNumberWithChar(grid);
			return grid;
		}

		if (n % 2 == 0)
		{
			for (int i = 0; i < grid.Length; i++)
			{
				char[] temp = new char[grid[i].Length];
				for (int j = 0; j < grid[i].Length; j++)
					temp[j] = 'O';

				grid[i] = new string(temp);
			}

			return grid;
		}
		
		n -= 2;
		n %= 4;
		for (int time = 1; time <= n + 2; time++)
		{
			for (int i = 0; i < grid.Length; i++)
			{
				for (int j = 0; j < grid[i].Length; j++)
				{
					// saving now. because we want to change it.
					bool canExplode = grid[i][j] == '1';
					if (grid[i][j] != '0')
					{
						int temp = int.Parse(grid[i][j].ToString()) - 1;
						grid[i] = ReplaceCharAtPosition(grid[i], j, temp.ToString());
					}
					else if (time % 2 == 0)
					{
						grid[i] = ReplaceCharAtPosition(grid[i], j, "3");
					}

					if (canExplode)
					{
						// me
						grid[i] = ReplaceCharAtPosition(grid[i], j, "0");

						// top
						if (i - 1 >= 0)
							grid[i - 1] = ReplaceCharAtPosition(grid[i - 1], j, "0");

						// bottom
						if (i + 1 < grid.Length && grid[i + 1][j] != '1')
							grid[i + 1] = ReplaceCharAtPosition(grid[i + 1], j, "0");

						// right
						if (j + 1 < grid[i].Length && grid[i][j + 1] != '1')
							grid[i] = ReplaceCharAtPosition(grid[i], j + 1, "0");

						// left
						if (j - 1 >= 0)
							grid[i] = ReplaceCharAtPosition(grid[i], j - 1, "0");
					}
				}
			}
		}

		ReplaceNumberWithChar(grid);
		return grid;
	}

	static string ReplaceCharAtPosition(string str, int pos, string toInsert)
	{
		str = str.Remove(pos, 1);
		str = str.Insert(pos, toInsert);
		return str;
	}

	static void ReplaceNumberWithChar(string[] grid)
	{
		for (int i = 0; i < grid.Length; i++)
		{
			grid[i] = grid[i].Replace("0", ".");
			grid[i] = grid[i].Replace("1", "O");
			grid[i] = grid[i].Replace("2", "O");
			grid[i] = grid[i].Replace("3", "O");
		}
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string[] rcn  = Console.ReadLine().Split(' ');
	// 	int      r    = Convert.ToInt32(rcn[0]);
	// 	int      c    = Convert.ToInt32(rcn[1]);
	// 	int      n    = Convert.ToInt32(rcn[2]);
	// 	string[] grid = new string [r];
	//
	// 	for (int i = 0; i < r; i++)
	// 	{
	// 		string gridItem = Console.ReadLine().Replace(".", "0").Replace("O", "3");
	// 		grid[i] = gridItem;
	// 	}
	//
	// 	string[] result = BomberMan(n, grid);
	// 	textWriter.WriteLine(string.Join("\n", result));
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}