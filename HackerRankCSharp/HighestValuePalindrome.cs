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

class HighestValuePalindrome
{
	// Complete the highestValuePalindrome function below.
	static string HighestValuePalindromeMethod(string str, int n, int k)
	{
		//Making palindrome
		int len  = str.Length;
		int l    = 0;
		int r    = len - 1;
		var ans  = new char[len];
		var mark = new bool[len];

		while (l <= r)
		{
			if (l == r)
			{
				ans[l] = ans[r] = str[l];
				break;
			}

			if (str[l] == str[r])
			{
				ans[l] = ans[r] = str[l];
			}
			else
			{
				if (str[l] > str[r])
				{
					mark[r] = true;
					ans[l]  = ans[r] = str[l];
				}
				else
				{
					mark[l] = true;
					ans[l]  = ans[r] = str[r];
				}

				k--;
			}

			l++;
			r--;
		}

		if (k < 0)
			return "-1";

		//Maximizing number
		l = 0;
		r = len - 1;
		while (l <= r)
		{
			if (l == r)
			{
				if (ans[l] != '9' && k >= 1)
					ans[l] = '9';
				break;
			}

			if (ans[l] < '9')
			{
				if (!mark[l] && !mark[r] && k >= 2)
				{
					k      -= 2;
					ans[l] =  ans[r] = '9';
				}
				else if ((mark[l] || mark[r]) && k >= 1)
				{
					k--;
					ans[l] = ans[r] = '9';
				}
			}

			l++;
			r--;
		}
		
		return new string(ans);
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		string[] nk = Console.ReadLine().Split(' ');

		int n = Convert.ToInt32(nk[0]);

		int k = Convert.ToInt32(nk[1]);

		string s = Console.ReadLine();

		string result = HighestValuePalindromeMethod(s, n, k);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}