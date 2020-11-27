public static string SubstringAfter(this string s, string sub,
	StringComparison comparison = StringComparison.Ordinal)
{
	var index = s.IndexOf(sub, comparison);
	return index < 0 ? string.Empty : s.Substring(index + sub.Length, s.Length - index - sub.Length);
}