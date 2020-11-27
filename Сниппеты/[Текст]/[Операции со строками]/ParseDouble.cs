public static double ParseDouble(this string s) =>
	double.Parse(s, NumberFormatInfo.InvariantInfo);