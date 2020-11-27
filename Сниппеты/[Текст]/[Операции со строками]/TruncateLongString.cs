public string TruncateLongString(string inputString, int maxChars, string postfix = ".")
{
	if (maxChars <= 0)
		throw new ArgumentOutOfRangeException("maxChars");            
	if (inputString == null || inputString.Length < maxChars)
		return inputString;

	var truncatedString = inputString.Substring(0, maxChars) + postfix;

	return truncatedString;
}