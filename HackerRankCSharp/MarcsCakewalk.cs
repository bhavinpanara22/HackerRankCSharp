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

class MarcsCakewalk
{
	// Complete the marcsCakewalk function below.
	static long MarcsCakewalkMethod(int[] calorie)
	{
		long result = 0;
		calorie = calorie.OrderByDescending(x => x).ToArray();
		for (int i = 0; i < calorie.Count(); i++)
			result += (long) (calorie[i] * Math.Pow(2, i));

		return result;
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[] calorie = Array.ConvertAll(Console.ReadLine().Split(' '), calorieTemp => Convert.ToInt32(calorieTemp));
	// 	long  result  = MarcsCakewalkMethod(calorie);
	//
	// 	textWriter.WriteLine(result);
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}