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

class BiggerIsGreater
{
	// Complete the biggerIsGreater function below.
	static string BiggerIsGreaterMethod(string w)
	{
		char[] array = w.ToCharArray();

		// find index from reverse, that has the lowest value till now. That index is called pivot.
		int i = array.Length - 1;
		while (i > 0 && array[i - 1] >= array[i])
			i--;

		if (i <= 0)
			return "no answer";

		// Find successor to pivot. 
		int j = array.Length - 1;
		while (array[j] <= array[i - 1])
			j--;

		char temp = array[i - 1];
		array[i - 1] = array[j];
		array[j]     = temp;

		// Reverse suffix
		j = array.Length - 1;
		while (i < j)
		{
			temp     = array[i];
			array[i] = array[j];
			array[j] = temp;
			i++;
			j--;
		}
		
		return new string(array);
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int T = Convert.ToInt32(Console.ReadLine());
	//
	// 	for (int TItr = 0; TItr < T; TItr++)
	// 	{
	// 		string w      = Console.ReadLine();
	// 		string result = BiggerIsGreaterMethod(w);
	//
	// 		textWriter.WriteLine(result);
	// 	}
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}