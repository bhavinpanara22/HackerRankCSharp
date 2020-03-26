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

class ThreeDSurfaceArea
{
	// Complete the surfaceArea function below.
	static int SurfaceArea(int[][] a)
	{
		int area = 2 * a.Length * a[0].Length;

		int side = 0;
		foreach (var row in a)
		{
			int last = 0;
			foreach (var column in row)
			{
				if (column > last)
					side += 2 * (column - last);
				last = column;
			}
		}

		int top = 0;
		for (int i = 0; i < a[0].Length; i++)
		{
			int last = 0;
			foreach (var column in a)
			{
				if (column[i] > last)
					top += 2 * (column[i] - last);
				last = column[i];
			}
		}

		area += side + top;
		return area;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		string[] hw = Console.ReadLine().Split(' ');

		int     h = Convert.ToInt32(hw[0]);
		int     w = Convert.ToInt32(hw[1]);
		int[][] a = new int[h][];

		for (int i = 0; i < h; i++)
			a[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));

		int result = SurfaceArea(a);
		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}