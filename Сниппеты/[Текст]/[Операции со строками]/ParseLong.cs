public static long ParseLong(this string s) =>
	long.Parse(s, NumberFormatInfo.InvariantInfo);