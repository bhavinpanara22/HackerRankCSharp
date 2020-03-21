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

class MaximumPerimeterTriangle
{
	// Complete the maximumPerimeterTriangle function below.
	static int[] MaximumPerimeterTriangleMethod(int[] sticks)
	{
		Array.Sort(sticks);

		int[] result = {-1, -1, -1};
		for (int i = sticks.Length - 1; i >= 2; i--)
		{
			if (sticks[i - 1] + sticks[i - 2] > sticks[i])
			{
				result[0] = sticks[i - 2];
				result[1] = sticks[i - 1];
				result[2] = sticks[i];
				break;
			}
		}

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[] sticks = Array.ConvertAll(Console.ReadLine().Split(' '), sticksTemp => Convert.ToInt32(sticksTemp));
	// 	int[] result = MaximumPerimeterTriangleMethod(sticks);
	//
	// 	textWriter.WriteLine(result[0] != -1 ? string.Join(" ", result) : "-1");
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}