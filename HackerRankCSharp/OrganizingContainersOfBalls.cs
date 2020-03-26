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

class OrganizingContainersOfBalls
{
	// Complete the organizingContainers function below.
	static string OrganizingContainers(int[][] container)
	{
		int[] rowSum    = new int[container.Length];
		int[] columnSum = new int[container.Length];

		for (int i = 0; i < container.Length; i++)
		{
			for (int j = 0; j < container[i].Length; j++)
			{
				rowSum[i]    += container[i][j];
				columnSum[j] += container[i][j];
			}
		}

		Array.Sort(rowSum);
		Array.Sort(columnSum);

		return rowSum.SequenceEqual(columnSum) ? "Possible" : "Impossible";
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int q = Convert.ToInt32(Console.ReadLine());
		for (int qItr = 0; qItr < q; qItr++)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			int[][] container = new int[n][];
			for (int i = 0; i < n; i++)
				container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));

			string result = OrganizingContainers(container);
			textWriter.WriteLine(result);
		}

		textWriter.Flush();
		textWriter.Close();
	}
}