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

class LuckBalance
{
	// Complete the luckBalance function below.
	static int LuckBalanceMethod(int k, int[][] contests)
	{
		int totalLuck = contests.Select(x => x[0]).Sum();

		var sorted = contests.OrderByDescending(x => x[1]).ThenBy(x => x[0]).ToArray();
		int count  = sorted.Count(x => x[1] == 1);
		for (int i = 0; i < count - k; i++)
			totalLuck -= 2 * sorted[i][0];

		// multiply by 2, because we have already added that value in total sum.
		// so minus it again for adding initially in totalSum
		return totalLuck;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	string[] nk = Console.ReadLine().Split(' ');
	//
	// 	int n = Convert.ToInt32(nk[0]);
	// 	int k = Convert.ToInt32(nk[1]);
	//
	// 	int[][] contests = new int[n][];
	//
	// 	for (int i = 0; i < n; i++)
	// 	{
	// 		contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
	// 	}
	//
	// 	int result = LuckBalanceMethod(k, contests);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}