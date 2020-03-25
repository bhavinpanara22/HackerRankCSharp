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

class ClimbingTheLeaderboard
{
	// Complete the climbingLeaderboard function below.
	static int[] ClimbingLeaderboard(int[] scores, int[] alice)
	{
		int[] result = new int[alice.Length];
		scores = scores.Distinct().ToArray();

		int i = scores.Length - 1;
		for (int j = 0; j < alice.Length; j++)
		{
			while (i >= 0)
			{
				if (alice[j] >= scores[i])
				{
					i--;
				}
				else
				{
					result[j] = i + 2;
					break;
				}
			}

			if (i < 0)
				result[j] = 1;
		}

		return result;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int scoresCount = Convert.ToInt32(Console.ReadLine());

		int[] scores     = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
		int   aliceCount = Convert.ToInt32(Console.ReadLine());

		int[] alice  = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));
		int[] result = ClimbingLeaderboard(scores, alice);

		textWriter.WriteLine(string.Join("\n", result));

		textWriter.Flush();
		textWriter.Close();
	}
}