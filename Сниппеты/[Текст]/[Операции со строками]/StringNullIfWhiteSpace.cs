public static string? NullIfWhiteSpace(this string s) =>
	!string.IsNullOrWhiteSpace(s)
	? s
	: null;