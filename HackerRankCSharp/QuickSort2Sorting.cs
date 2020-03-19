using System;
using System.Collections.Generic;
using System.IO;

class QuickSort2Sorting
{
	static void QuickSort(int[] ar, int minPos, int maxPos)
	{
		if (minPos >= maxPos)
			return;

		List<int> leftList  = new List<int>();
		List<int> rightList = new List<int>();
		int       pivot     = ar[minPos];
		for (int i = minPos + 1; i <= maxPos; i++)
		{
			if (ar[i] > pivot)
				rightList.Add(ar[i]);
			else
				leftList.Add(ar[i]);
		}

		int index = minPos;
		foreach (var num in leftList)
			ar[index++] = num;

		ar[index++] = pivot;

		foreach (var num in rightList)
			ar[index++] = num;

		QuickSort(ar, minPos, minPos + leftList.Count - 1);
		QuickSort(ar, minPos + leftList.Count + 1, maxPos);

		PrintArray(ar, minPos, maxPos);
	}

	static void PrintArray(int[] ar, int start, int end)
	{
		for (int i = start; i <= end; i++)
			Console.Write(ar[i] + " ");

		Console.WriteLine("");
	}

/* Tail starts here */
	static void Main(String[] args)
	{
		int _ar_size;
		_ar_size = Convert.ToInt32(Console.ReadLine());
		int[]    _ar            = new int [_ar_size];
		String   elements       = Console.ReadLine();
		String[] split_elements = elements.Split(' ');
		for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
		{
			_ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
		}

		QuickSort(_ar, 0, _ar_size - 1);
	}
}