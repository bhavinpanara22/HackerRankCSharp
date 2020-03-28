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

class EmasSuperComputer
{
	// Complete the twoPluses function below.
	/*
	 * 		15 15
		BBGBGGGGGBBGGBB
		BBGBGGGGGBBGGBB
		GGGGGGGGGGGGGGG
		GGGGGGGGGGGGGGG
		BBGBGGGGGBBGGBB
		BBGBGGGGGBBGGBB
		BBGBGGGGGBBGGBB
		GGGGGGGGGGGGGGG
		BBGBGGGGGBBGGBB
		BBGBGGGGGBBGGBB
		BBGBGGGGGBBGGBB
		BBGBGGGGGBBGGBB
		BBGBGGGGGBBGGBB
		BBGBGGGGGBBGGBB
		GGGGGGGGGGGGGGG
	 */
	static int TwoPluses(string[] grid)
	{
		char[][] c = new char[grid.Length][];
		for (int i = 0; i < grid.Length; i++)
			c[i] = grid[i].ToCharArray();

		int row = c.Length, col = c[0].Length;
		int ans = 0;
		for (int x = 0; x < row; x++)
		{
			for (int y = 0; y < col; y++)
			{
				int r = 0;
				while (x + r < row && c[x + r][y] == 'G' &&
				       x - r >= 0 && c[x - r][y] == 'G' &&
				       y + r < col && c[x][y + r] == 'G' &&
				       y - r >= 0 && c[x][y - r] == 'G')
				{
					c[x + r][y] = c[x - r][y] = c[x][y + r] = c[x][y - r] = 'g';
					for (int x1 = 0; x1 < row; x1++)
					{
						for (int y1 = 0; y1 < col; y1++)
						{
							int r1 = 0;
							while (x1 + r1 < row && c[x1 + r1][y1] == 'G' &&
							       x1 - r1 >= 0 && c[x1 - r1][y1] == 'G' &&
							       y1 + r1 < col && c[x1][y1 + r1] == 'G' &&
							       y1 - r1 >= 0 && c[x1][y1 - r1] == 'G')
							{
								ans = Math.Max(ans, (1 + 4 * r) * (1 + 4 * r1));
								r1++;
							}
						}
					}

					r++;
				}

				r = 0;
				while (x + r < row && c[x + r][y] == 'g' &&
				       x - r >= 0 && c[x - r][y] == 'g' &&
				       y + r < col && c[x][y + r] == 'g' &&
				       y - r >= 0 && c[x][y - r] == 'g')
				{
					c[x + r][y] = c[x - r][y] = c[x][y + r] = c[x][y - r] = 'G';
					r++;
				}
			}
		}

		return ans;
	}

	static void Main(string[] args)
	{
		// TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		string[] nm   = Console.ReadLine().Split(' ');
		int      n    = Convert.ToInt32(nm[0]);
		int      m    = Convert.ToInt32(nm[1]);
		string[] grid = new string [n];

		for (int i = 0; i < n; i++)
		{
			string gridItem = Console.ReadLine();
			grid[i] = gridItem;
		}

		int result = TwoPluses(grid);

		Console.WriteLine(result);
		// textWriter.Flush();
		// textWriter.Close();
	}
}