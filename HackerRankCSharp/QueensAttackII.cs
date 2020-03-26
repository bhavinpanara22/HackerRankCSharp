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

class QueensAttackII
{
	// Complete the queensAttack function below.
	static int QueensAttack(int n, int k, int r, int c, int[][] obstacles)
	{
		int right       = int.MaxValue;
		int topRight    = int.MaxValue;
		int top         = int.MaxValue;
		int topLeft     = int.MaxValue;
		int left        = int.MaxValue;
		int bottomLeft  = int.MaxValue;
		int bottom      = int.MaxValue;
		int bottomRight = int.MaxValue;

		var useful = obstacles.Where(temp => temp[0] == r
		                                  || temp[1] == c
		                                  || Math.Abs(temp[0] - r) == Math.Abs(temp[1] - c));

		foreach (var obstacle in useful)
		{
			// right & left
			if (obstacle[0] == r)
			{
				if (obstacle[1] > c)
					right = Math.Min(right, Math.Abs(obstacle[1] - c) - 1);
				else
					left = Math.Min(left, Math.Abs(obstacle[1] - c) - 1);
			}
			else if (obstacle[1] == c)
			{
				// top & bottom
				if (obstacle[0] > r)
					top = Math.Min(top, Math.Abs(obstacle[0] - r) - 1);
				else
					bottom = Math.Min(bottom, Math.Abs(obstacle[0] - r) - 1);
			}
			else if (obstacle[0] > r)
			{
				// top right && top left
				if (obstacle[1] > c)
					topRight = Math.Min(topRight, Math.Abs(obstacle[0] - r) - 1);
				else
					topLeft = Math.Min(topLeft, Math.Abs(obstacle[0] - r) - 1);
			}
			else
			{
				// bottom right & bottom left
				if (obstacle[1] > c)
					bottomRight = Math.Min(bottomRight, Math.Abs(obstacle[0] - r) - 1);
				else
					bottomLeft = Math.Min(bottomLeft, Math.Abs(obstacle[0] - r) - 1);
			}
		}

		// if we do not find any
		if (right == int.MaxValue)
			right = n - c;

		if (left == int.MaxValue)
			left = c - 1;

		if (top == int.MaxValue)
			top = n - r;

		if (bottom == int.MaxValue)
			bottom = r - 1;

		if (topRight == int.MaxValue)
			topRight = Math.Min(n - c, n - r);

		if (topLeft == int.MaxValue)
			topLeft = Math.Min(n - r, c - 1);

		if (bottomLeft == int.MaxValue)
			bottomLeft = Math.Min(c - 1, r - 1);

		if (bottomRight == int.MaxValue)
			bottomRight = Math.Min(n - c, r - 1);

		return right + topRight + top + topLeft + left + bottomLeft + bottom + bottomRight;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		string[] nk = Console.ReadLine().Split(' ');
		int      n  = Convert.ToInt32(nk[0]);
		int      k  = Convert.ToInt32(nk[1]);

		string[] r_qC_q = Console.ReadLine().Split(' ');
		int      r_q    = Convert.ToInt32(r_qC_q[0]);
		int      c_q    = Convert.ToInt32(r_qC_q[1]);

		int[][] obstacles = new int[k][];
		for (int i = 0; i < k; i++)
			obstacles[i] = Array.ConvertAll(Console.ReadLine().Split(' '), obstaclesTemp => Convert.ToInt32(obstaclesTemp));

		int result = QueensAttack(n, k, r_q, c_q, obstacles);
		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}