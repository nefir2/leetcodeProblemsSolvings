namespace myatoiProj
{
	public class Solution
	{
		public int MyAtoi(string s)
		{
			const int ZERO = 0;
			const int ONE = 1;
			const char MINUS = '-';
			const char PLUS = '+';
			const char ZERO_CHAR = '0';

			while (s.Length > ZERO && char.IsWhiteSpace(s.First())) {
				if (char.IsWhiteSpace(s.First())) s = s.Substring(ONE);
				else break;
			}
			if (s.Length == ZERO) return ZERO;
			if (s.First().Equals(PLUS) || s.First().Equals(MINUS)) {
				if (s.Length == ONE) return ZERO;
				if (s.Length > ONE && !char.IsDigit(s[ONE])) return ZERO;
				if (s.First().Equals(PLUS)) s = s.Substring(ONE);
			}
			bool searchLeadingZeros = true;
			for (int i = s.First().Equals(MINUS) ? ONE : ZERO; i < s.Length; i++) {
				if (searchLeadingZeros && !s[i].Equals(ZERO_CHAR)) searchLeadingZeros = false;
				if (searchLeadingZeros && s[i].Equals(ZERO_CHAR)) 
				{
					s = s.Remove(i, ONE);
					i--;
					continue;
				}
				if (!char.IsDigit(s[i])) {
					s = s.Substring(ZERO, i);
					break;
				}
			}
			if (s.Length == ZERO || s.Equals(MINUS.ToString()) || s.Equals(PLUS.ToString())) return ZERO;
			return Convert.ToInt32(double.Min(double.Max(int.MinValue, double.Parse(s)), int.MaxValue));
		}
	}
}
