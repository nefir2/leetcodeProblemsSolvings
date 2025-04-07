using System;

namespace lc
{
	public class Solution
	{
		private static void Main(string[] args)
		{
			Console.WriteLine($"args length: {args.Length}");
		}
		public static bool IsPalindrome(int x)
		{
			if (x < 0) return false;
			
			// do {

			// } while ();

			return false;
		}
		public static bool EasyWay(int x)
		{
			string value = x.ToString();
			bool outp = false;
			int indexOfLast = value.Length - 1;
			for (int i = 0; i < value.Length; i++)
			{
				if (value[i] == value[indexOfLast - i]) 
				{
					if (i >= indexOfLast - i) return true;
					continue;
				}
				else break;
			}
			return outp;
		}
	}
}