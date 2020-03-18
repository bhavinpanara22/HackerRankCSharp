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

class IntroToTutorialChallenges
{
	// Complete the introTutorial function below.
	static int IntroTutorial(int V, int[] arr)
	{
		int index = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == V)
			{
				index = i;
				break;
			}
		}

		return index;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int V = Convert.ToInt32(Console.ReadLine());
		int n = Convert.ToInt32(Console.ReadLine());

		int[] arr    = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		int   result = IntroTutorial(V, arr);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}