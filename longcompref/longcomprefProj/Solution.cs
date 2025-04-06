namespace longcomprefProj
{
	public class Solution
	{
		internal const int ZERO = 0;
		public string LongestCommonPrefix(string[] strs)
		{
			string prefix = string.Empty;
			int minLength = ShortestStringLength(strs);
			for (int i = ZERO; i < minLength; i++)
			{
				bool toBreak = false;
				prefix += strs[ZERO][i];
				for (int j = ZERO; j < strs.Length; j++)
				{
					if (!strs[j][i].Equals(prefix[i])) {
						prefix = prefix.RemoveLastChar();
						toBreak = true;
						break;
					}
					else continue;
				}
				if (toBreak) break;
			}
			return prefix;
		}
		public static int ShortestStringLength(string[] strings)
		{
			if (strings.Length == ZERO) return ZERO;
			int length = strings.First().Length;
			for (int i = ZERO; i < strings.Length; i++)
			{
				int currLength = strings[i].Length;
				if (currLength < length) length = currLength;
			}
			return length;
		}
	}
	public static class MyArrayExtension
	{
		public static string RemoveLastChar(this string str)
		{
			List<char> strArr = str.ToList();
			strArr.RemoveAt(strArr.Count - 1);
			return strArr.ToArray().CharArrayToString();
		}

		public static string CharArrayToString(this char[] array)
		{
			string outp = "";
			for (int i = Solution.ZERO; i < array.Length; i++) outp += array[i];
			return outp;
		}
	}
}
