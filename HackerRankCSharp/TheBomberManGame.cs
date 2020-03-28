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
	static char[][] BomberMan(int n, char[][] grid)
	{
		if (n == 1)
			return grid;

		int row = grid.Length, col = grid[0].Length;
		if (n % 2 == 0)
		{
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
					grid[i][j] = 'O';
			}
		}
		else
		{
			n /= 2;

			int num = Math.Min(n, ((n + 1) % 2) + 1);
			for (int itr = 1; itr <= num; itr++)
			{
				char[][] newGrid = new char[grid.Length][];
				for (int i = 0; i < row; i++)
				{
					char[] temp = new char[grid[i].Length];
					for (int j = 0; j < col; j++)
						temp[j] = 'O';
					newGrid[i] = temp;
				}

				for (int i = 0; i < row; i++)
				{
					for (int j = 0; j < col; j++)
					{
						if (grid[i][j] != 'O')
							continue;

						SetGrid(newGrid, i, j, '.');
						SetGrid(newGrid, i + 1, j, '.');
						SetGrid(newGrid, i - 1, j, '.');
						SetGrid(newGrid, i, j + 1, '.');
						SetGrid(newGrid, i, j - 1, '.');
					}
				}

				grid = newGrid;
			}
		}

		return grid;
	}

	static void SetGrid(char[][] newGrid, int i, int j, char ch)
	{
		if (i >= 0 && i < newGrid.Length && j >= 0 && j < newGrid[0].Length)
			newGrid[i][j] = ch;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string[] rcn = Console.ReadLine().Split(' ');
	//
	// 	int r = Convert.ToInt32(rcn[0]);
	// 	int c = Convert.ToInt32(rcn[1]);
	// 	int n = Convert.ToInt32(rcn[2]);
	//
	// 	char[][] grid = new char[r][];
	// 	for (int i = 0; i < r; i++)
	// 		grid[i] = Console.ReadLine().Replace(".", "0").Replace("O", "3").ToCharArray();
	//
	// 	char[][] result = BomberMan(n, grid);
	// 	foreach (var temp in result)
	// 		Console.WriteLine(new string(temp));
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}