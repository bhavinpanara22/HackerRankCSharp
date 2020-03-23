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

class JimAndTheOrders
{
	// Complete the jimOrders function below.
	static int[] JimOrders(int[][] orders)
	{
		Dictionary<int, int> result = new Dictionary<int, int>();
		for (int i = 0; i < orders.Length; i++)
			result.Add(i + 1, orders[i].Sum());

		return result.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToArray();
	}

	// static void Main(string[] args)
	// {
	// 	TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
	//
	// 	int n = Convert.ToInt32(Console.ReadLine());
	//
	// 	int[][] orders = new int[n][];
	//
	// 	for (int i = 0; i < n; i++)
	// 	{
	// 		orders[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
	// 	}
	//
	// 	int[] result = JimOrders(orders);
	//
	// 	textWriter.WriteLine(string.Join(" ", result));
	//
	// 	textWriter.Flush();
	// 	textWriter.Close();
	// }
}