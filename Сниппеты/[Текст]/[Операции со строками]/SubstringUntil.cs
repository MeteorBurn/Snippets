public static string SubstringUntil(this string s, string sub,
	StringComparison comparison = StringComparison.Ordinal)
{
	var index = s.IndexOf(sub, comparison);
	return index < 0 ? s : s.Substring(0, index);
}