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
using System.Linq.Expressions;

class TheTimeInWords
{
	// Complete the timeInWords function below.
	static string TimeInWords(int h, int m)
	{
		List<string> words = new List<string>
		{
			"zero",
			"one",
			"two",
			"three",
			"four",
			"five",
			"six",
			"seven",
			"eight",
			"nine",
			"ten",
			"eleven",
			"twelve",
			"thirteen",
			"fourteen",
			"quarter",
			"sixteen",
			"seventeen",
			"eighteen",
			"nineteen",
			"twenty",
			"twenty one",
			"twenty two",
			"twenty three",
			"twenty four",
			"twenty five",
			"twenty six",
			"twenty seven",
			"twenty eight",
			"twenty nine"
		};

		string unit      = m == 1 || m == 59 ? "minute" : "minutes";
		string aheadHour = h == 12 ? words[1] : words[h + 1];

		string time;
		switch (m)
		{
			case 0:
				time = words[h] + " o' clock";
				break;
			case 15:
				time = "quarter past " + words[h];
				break;
			case 30:
				time = "half past " + words[h];
				break;
			case 45:
				time = "quarter to " + aheadHour;
				break;
			default:
			{
				if (m > 0 && m < 30)
					time = words[m] + " " + unit + " past " + words[h];
				else
					time = words[60 - m] + " " + unit + " to " + aheadHour;
				break;
			}
		}

		return time;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int h = Convert.ToInt32(Console.ReadLine());
		int m = Convert.ToInt32(Console.ReadLine());

		string result = TimeInWords(h, m);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}