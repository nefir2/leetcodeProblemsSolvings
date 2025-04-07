namespace myatoiProj
{
	public static class MyStringExtension
	{
		public static string RemoveCharById(this string s, int id)
		{
			if (id > s.Length || id < 0) throw new ArgumentOutOfRangeException(nameof(id));
			List<char> list = s.ToList();
			list.RemoveAt(id);
			return new string(list.ToArray());
		}
	}
}