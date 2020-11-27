public static string[] Split(this string input, params string[] separators)
{ 
	return input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
}