using System;

namespace ExtensionMethods
{
	public static class MyExtensions
	{
		public static int WordCount (this String str)
		{
			return str.Split (new char[] { ' ', '.', '?' }, 
				StringSplitOptions.RemoveEmptyEntries).Length;
		}

		public static string TestString (this String str)
		{
			if (!string.IsNullOrEmpty (str))
				return Convert.ToDouble (str);
			else
				Console.Write (str & " value is null or empty");
		}
	}
}


