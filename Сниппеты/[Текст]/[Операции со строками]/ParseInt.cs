public static int ParseInt(this string s) =>
	int.Parse(s, NumberFormatInfo.InvariantInfo);