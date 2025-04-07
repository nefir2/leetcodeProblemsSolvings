namespace longcomprefProj
{
	public class Solution
	{
		internal const int ZERO = 0;
		public string LongestCommonPrefix(string[] strs)
		{
			string prefix = string.Empty;
			for (int i = ZERO; i < ShortestStringLength(strs); i++)
			{
				bool toBreak = false;
				prefix += strs[ZERO][i];
				for (int j = ZERO; j < strs.Length; j++)
				{
					if (!strs[j][i].Equals(prefix[i])) {
						prefix = prefix[..^1];
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
			int length = strings[ZERO].Length;
			for (int i = ZERO; i < strings.Length; i++) if (strings[i].Length < length) length = strings[i].Length;
			return length;
		}
	}
}
