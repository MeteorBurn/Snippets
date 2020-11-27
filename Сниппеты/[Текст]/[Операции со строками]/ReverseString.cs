public static string Reverse(this string s)
{
	var buffer = new StringBuilder(s.Length);

	for (var i = s.Length - 1; i >= 0; i--)
		buffer.Append(s[i]);

		return buffer.ToString();
}