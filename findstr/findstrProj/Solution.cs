using System.Linq;

namespace findstrProj
{
	public class Solution
	{
		public int StrStr(string haystack, string needle) 
		{
			const int STD_OUTP = -1;
			if (haystack.Length < needle.Length) return STD_OUTP;
			for (int i = 0; i < haystack.Length; i++)
			{
				if (haystack[i] == needle.First())
				{
					if (i + needle.Length - 1 >= haystack.Length) return STD_OUTP;
					bool found = false;
					for (int j = 0; j < needle.Length; j++)
					{
						found = false;
						if (haystack[i + j] != needle[j]) break;
						found = true;
					}
					if (found) return i;
				}
				else continue;
			}
			return STD_OUTP;
		}
	}
}