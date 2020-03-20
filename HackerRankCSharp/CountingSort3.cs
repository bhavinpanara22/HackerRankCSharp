using System;
using System.Collections.Generic;
using System.IO;

class CountingSort3
{
	static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

		int   n      = Convert.ToInt32(Console.ReadLine());
		int[] counts = new int[100];
		for (int i = 0; i < n; i++)
		{
			int temp = Convert.ToInt32(Console.ReadLine().Split(' ')[0]);
			counts[temp]++;
		}

		int sum = 0;
		for (int i = 0; i < counts.Length; i++)
		{
			sum += counts[i];
			Console.Write(sum + " ");
		}
	}
}