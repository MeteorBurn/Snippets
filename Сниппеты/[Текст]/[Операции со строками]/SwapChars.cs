public static string SwapChars(this string s, int firstCharIndex, int secondCharIndex) => new StringBuilder(s)
{
	[firstCharIndex] = s[secondCharIndex],
	[secondCharIndex] = s[firstCharIndex]
}.ToString();